using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using payroll.Models;
using payroll.ViewModels;
using payroll.Helpers;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace payroll.Controllers
{
    [Authorize(Policy = "ApiUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class ForgotPasswordController : Controller
    {
        private readonly IntegraDbContext _appDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public ForgotPasswordController(UserManager<AppUser> userManager, IMapper mapper, IntegraDbContext appDbContext)
        {
            _userManager = userManager;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        // POST api/accounts
        [HttpPost]
        public async Task<ActionResult<ResultReponser>> ForgotPassword([FromBody]ForgotPassViewModel model)
        {
            var forgotValidate = await _appDbContext.VwsEmployees
                .Where(e => e.EmployeeNo == model.UserName)
                .Where(e => e.LastName == model.LastName.ToUpper())
                .Where(e => e.Birthday == DateTime.Parse(model.Birthday))
                .FirstOrDefaultAsync();
            if (forgotValidate != null)
            {
                AppUser validateSecret = new AppUser();
                var secretFilter = _userManager.Users;
                switch (model.SecretQuestion)
                {
                    case 1:
                        validateSecret = secretFilter
                            .Where(u => u.QuestionOne == model.SecretAnswer)
                            .FirstOrDefault();
                        break;
                    case 2:
                        validateSecret = secretFilter
                            .Where(u => u.QuestionTwo == model.SecretAnswer)
                            .FirstOrDefault();
                        break;
                    case 3:
                        validateSecret = secretFilter
                            .Where(u => u.QuestionThree == model.SecretAnswer)
                            .FirstOrDefault();
                        break;
                    default:
                        validateSecret = new AppUser();
                        break;
                }
                if (validateSecret != null)
                {
                    var user = await _userManager.FindByNameAsync(model.UserName);
                    await _userManager.RemovePasswordAsync(user);
                    var result = await _userManager.AddPasswordAsync(user, "123456");
                    if (result.Succeeded)
                    {
                        return new ResultReponser
                        {
                            Result = "success",
                            Message = "Your password is successfully reset to default password.",
                            ResponseData = ""
                        };
                    }
                    else
                    {
                        return new ResultReponser
                        {
                            Result = "failed",
                            Message = "Something problem",
                            ResponseData = ""
                        };
                    }
                }
                else
                {
                    return new ResultReponser
                    {
                        Result = "failed",
                        Message = "Invalid answer to the secret question.",
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

        // PUT: api/Employee/5
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutEmployee(int id, Employee employee)
        // {
        //     if (id != employee.Id)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(employee).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!EmployeeExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // DELETE: api/Employee/5
        // [HttpDelete("{id}")]
        // public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        // {
        //     var employee = await _context.Employee.FindAsync(id);
        //     if (employee == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.Employee.Remove(employee);
        //     await _context.SaveChangesAsync();

        //     return employee;
        // }
    }
}