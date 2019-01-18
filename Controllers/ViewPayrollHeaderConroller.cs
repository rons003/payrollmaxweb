using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using payroll.Models;
using Newtonsoft.Json.Bson;
using Microsoft.AspNetCore.Authorization;

namespace payroll.Controllers
{
    [Authorize(Policy = "ApiUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class ViewPayrollHeaderController : ControllerBase
    {
        private readonly IntegraDbContext _context;

        public ViewPayrollHeaderController(IntegraDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<VwsPayrollHeader>>> GetPayrollPeriod(int id)
        {
            var payrollPeriod = await _context.VwsPayrollHeaders
                .Where(pp => pp.EmployeeNo == id.ToString())
                .Where(pp => pp.Validated == "Y")
                .Select(
                    pp => new VwsPayrollHeader() {
                        EmployeeNo = pp.EmployeeNo,
                        PayrollPeriod = pp.PayrollPeriod,
                        NetPay = pp.NetPay
                    }
                )
                .ToListAsync();

            if (payrollPeriod == null)
            {
                return NotFound();
            }

            return payrollPeriod;
        }
    }
}