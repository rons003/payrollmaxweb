using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using payroll.Models;
using Microsoft.AspNetCore.Authorization;

namespace payroll.Controllers
{
    [Authorize(Policy = "ApiUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class ViewEmployeeController : ControllerBase
    {
        private readonly IntegraDbContext _context;

        public ViewEmployeeController(IntegraDbContext context)
        {
            _context = context;
        }

        // GET: api/ViewEmployee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VwsEmployee>>> GetVwsEmployees()
        {
            return await _context.VwsEmployees.ToListAsync();
        }

        // GET: api/ViewEmployee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VwsEmployee>> GetVwsEmployee(string id)
        {
            var vwsEmployee = await _context.VwsEmployees
                .Where(e => e.EmployeeNo == id)
                .Select(
                    e => new VwsEmployee()
                    {
                        EmployeeName = e.EmployeeName
                    }
                ).FirstOrDefaultAsync();

            if (vwsEmployee == null)
            {
                return Ok(
                    new
                    {
                        result = "success",
                        message = "Employee Not Found!"
                    });
            }

            return vwsEmployee;
        }
    }
}
