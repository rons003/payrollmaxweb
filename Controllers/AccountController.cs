using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using payroll.Models;
using payroll.ViewModels;
using payroll.Helpers;
using System;

namespace payroll.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly IntegraDbContext _appDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public AccountsController(UserManager<AppUser> userManager, IMapper mapper, IntegraDbContext appDbContext)
        {
            _userManager = userManager;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        // POST api/accounts
        [HttpPost]
        public async Task<ActionResult<ResultReponser>> Register([FromBody]RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employeeValidate = _appDbContext.VwsEmployees
                .Where(e => e.EmployeeNo == model.UserName)
                .Where(e => e.MiddleInitial == model.MiddleInitial + '.')
                .Where(e => e.Birthday == DateTime.Parse(model.Birthday))
                .FirstOrDefault();

            if (employeeValidate != null)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user == null)
                {
                    var email = await _userManager.FindByEmailAsync(model.Email);
                    if (email == null)
                    {
                        var userIdentity = _mapper.Map<AppUser>(model);

                        var result = await _userManager.CreateAsync(userIdentity, model.Password);

                        if (result.Succeeded)
                        {
                            // here we assign the new user the "Admin" role 
                            await _userManager.AddToRoleAsync(userIdentity, "Employee");
                            await _appDbContext.SaveChangesAsync();
                            return new ResultReponser
                            {
                                Result = "success",
                                Message = "Account has successfully created!",
                                ResponseData = ""
                            };
                        }
                        else
                        {
                            return new ResultReponser
                            {
                                Result = "badrequest",
                                Message = "Something Problem!",
                                ResponseData = ""
                            };
                        }
                    }
                    else
                    {
                        return new ResultReponser
                        {
                            Result = "failed",
                            Message = "Email Address is Already used!",
                            ResponseData = ""
                        };
                    }
                }
                else
                {
                    return new ResultReponser
                    {
                        Result = "failed",
                        Message = "Employee Number is Already Exist!",
                        ResponseData = ""
                    };
                }
            }
            else
            {
                return new ResultReponser
                {
                    Result = "failed",
                    Message = "Invalid information request if you may have a concern please contact to our HR.",
                    ResponseData = ""
                };
            }

        }
    }
}