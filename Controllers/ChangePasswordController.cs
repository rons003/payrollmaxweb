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
    public class ChangePasswordController : Controller
    {
        private readonly IntegraDbContext _appDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public ChangePasswordController(UserManager<AppUser> userManager, IMapper mapper, IntegraDbContext appDbContext)
        {
            _userManager = userManager;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        // POST api/accounts
        [HttpPost]
        public async Task<ActionResult<ResultReponser>> ChangePassword([FromBody]ChangepassViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                return new ResultReponser
                {
                    Result = "success",
                    Message = "Successfully!",
                    ResponseData = ""
                };
            }
            else
            {
                return new ResultReponser
                {
                    Result = "failed",
                    Message = "Invalid Password!",
                    ResponseData = ""
                };
            }
        }
    }
}