using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.Server.Data;
using project.Shared.Domain;
using project.Server.IRepository;

namespace project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //private PaymentController(ApplicationDbContext context)
        public PaymentController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/Payment
        [HttpGet]
        //Refactored
        // public async Task<ActionResult<IEnumerable<Payment>>> GetPayment()
        public async Task<IActionResult> GetPayment()
        {

            //Refactored
            //return await _context.Payment.ToListAsync();
            var payment = await _unitOfWork.Payment.GetAll();
            return Ok(payment);
        }

        // GET: api/Payment/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Payment>> GetPayment(int id)
        public async Task<IActionResult> GetPayment(int id)
        {
            //Refactored
            //var payment = await _context.Payment.FindAsync(id);
            var payment = await _unitOfWork.Payment.Get(q => q.Id == id);

            if (payment == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(payment);
        }

        // PUT: api/Payment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(int id, Payments payment)
        {
            if (id != payment.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(payment).State = EntityState.Modified;
            _unitOfWork.Payment.Update(payment);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!PaymentExists(id))
                if (!await PaymentExists(id))
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



        // POST: api/Payment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Payments>> PostPayment(Payments payment)
        {
            //Refactored
            // _context.Payment.Add(payment);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Payment.Insert(payment);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPayment", new { id = payment.Id }, payment);
        }

        // DELETE: api/Payment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            //Refactored
            //var payment = await _context.Payment.FindAsync(id);
            var payment = await _unitOfWork.Payment.Get(q => q.Id == id);
            if (payment == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Payment.Remove(payment);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Payment.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        // private bool PaymentExists(int id)
        private async Task<bool> PaymentExists(int id)
        {
            //Refactored
            // return _context.Payment.Any(e => e.Id == id);

            var payment = await _unitOfWork.Payment.Get(q => q.Id == id);
            return payment != null;

        }
    }
}

