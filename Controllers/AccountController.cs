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
        public async Task<IActionResult> Register([FromBody]RegistrationViewModel model)
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
                    var userIdentity = _mapper.Map<AppUser>(model);

                    var result = await _userManager.CreateAsync(userIdentity, model.Password);

                    if (result.Succeeded)
                    {
                        // here we assign the new user the "Admin" role 
                        await _userManager.AddToRoleAsync(userIdentity, "Employee");
                        await _appDbContext.SaveChangesAsync();
                        return new OkObjectResult("Account created");
                    }
                    else
                    {
                        return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));
                    }


                }
                else
                {
                    return new OkObjectResult("Employee Number is already exist!");
                }
            }
            else
            {
                return new OkObjectResult("Information is not Matching...");
            }

        }
    }
}