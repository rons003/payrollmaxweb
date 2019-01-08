using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using payroll.Models;

namespace payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollHeadController : ControllerBase
    {
        private readonly IntegraDbContext _context;

        public PayrollHeadController(IntegraDbContext context)
        {
            _context = context;
        }

        // GET: api/PayrollHead
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PayrollHeader>>> GetPayrollHeader()
        {
            return await _context.PayrollHeader.ToListAsync();
        }

        // GET: api/PayrollHead/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<PayrollHeader>>> GetPayrollHeader(string id)
        {
            var payrollHeader = await _context.PayrollHeader
                .Where(e => e.EmployeeNo == id)
                .Where(e => e.Validated == "Y")
                .ToListAsync();

            if (payrollHeader == null)
            {
                return NotFound();
            }

            return payrollHeader;
        }

        // PUT: api/PayrollHead/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayrollHeader(string id, PayrollHeader payrollHeader)
        {
            if (id != payrollHeader.PayrollPeriod)
            {
                return BadRequest();
            }

            _context.Entry(payrollHeader).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PayrollHeaderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PayrollHead
        [HttpPost]
        public async Task<ActionResult<PayrollHeader>> PostPayrollHeader(PayrollHeader payrollHeader)
        {
            _context.PayrollHeader.Add(payrollHeader);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPayrollHeader", new { id = payrollHeader.PayrollPeriod }, payrollHeader);
        }

        // DELETE: api/PayrollHead/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PayrollHeader>> DeletePayrollHeader(string id)
        {
            var payrollHeader = await _context.PayrollHeader.FindAsync(id);
            if (payrollHeader == null)
            {
                return NotFound();
            }

            _context.PayrollHeader.Remove(payrollHeader);
            await _context.SaveChangesAsync();

            return payrollHeader;
        }

        private bool PayrollHeaderExists(string id)
        {
            return _context.PayrollHeader.Any(e => e.PayrollPeriod == id);
        }
    }
}
