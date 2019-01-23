using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using payroll.Models;
using payroll.ViewModels;
using payroll.Helpers;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : Controller
    {
        private readonly IntegraDbContext _appDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public AccountsController(UserManager<AppUser> userManager, IMapper mapper, IntegraDbContext appDbContext, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        // GET api/accounts
        [Authorize(Policy = "ApiUser")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAllUsers()
        {
            var users = await _userManager.Users
            .FromSql(
                "SELECT a.* FROM AspNetUsers a LEFT JOIN AspNetUserRoles b ON(a.Id=b.UserId) " +
                "LEFT JOIN AspNetRoles c ON(c.Id=b.RoleId) WHERE c.Name = 'Employee'"
            )
            .Select(
                    u => new AppUser()
                    {
                        Id = u.Id,
                        UserName = u.UserName,
                        Email = u.Email
                    }
            ).Take(50).ToListAsync();
            return users;
        }

        // GET api/accounts/id
        [Authorize(Policy = "ApiUser")]
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AppUser>>> searchUser(string id = "")
        {
            var users = await _userManager.Users
            .FromSql(
                "SELECT a.* FROM AspNetUsers a LEFT JOIN AspNetUserRoles b ON(a.Id=b.UserId) " +
                "LEFT JOIN AspNetRoles c ON(c.Id=b.RoleId) WHERE c.Name = 'Employee'"
            )
            .Where(u => u.UserName.Contains(id))
            .Select(
                    u => new AppUser()
                    {
                        Id = u.Id,
                        UserName = u.UserName,
                        Email = u.Email
                    }
            ).ToListAsync();
            return users;
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
                .Where(e => e.LastName == model.LastName.ToUpper())
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

        // Delete api/accounts/id
        [HttpDelete("{id}")]
        public async Task<ActionResult<ResultReponser>> DeleteAccount(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return new ResultReponser
                {
                    Result = "success",
                    Message = "Account has successfully removed.",
                    ResponseData = ""
                };
            }
            else
            {
                return new ResultReponser
                {
                    Result = "failed",
                    Message = "Something Problem",
                    ResponseData = ""
                };
            }
        }
    }
}