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
    public class PaymentConfirationController : ControllerBase
    {

        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //private PaymentConfirmationController(ApplicationDbContext context)
        public PaymentConfirationController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/PaymentConfirmation
        [HttpGet]
        //Refactored
        // public async Task<ActionResult<IEnumerable<PaymentConfirmation>>> GetPaymentConfirmation()
        public async Task<IActionResult> GetPaymentConfirmation()
        {

            //Refactored
            //return await _context.PaymentConfirmation.ToListAsync();
            var paymentConfirmation = await _unitOfWork.PaymentConfirmation.GetAll();
            return Ok(paymentConfirmation);
        }

        // GET: api/PaymentConfirmation/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<PaymentConfirmation>> GetPaymentConfirmation(int id)
        public async Task<IActionResult> GetPaymentConfirmation(int id)
        {
            //Refactored
            //var paymentConfirmation = await _context.PaymentConfirmation.FindAsync(id);
            var paymentConfirmation = await _unitOfWork.PaymentConfirmation.Get(q => q.Id == id);

            if (paymentConfirmation == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(paymentConfirmation);
        }

        // PUT: api/PaymentConfirmation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentConfirmation(int id, PaymentConfirmation paymentConfirmation)
        {
            if (id != paymentConfirmation.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(paymentConfirmation).State = EntityState.Modified;
            _unitOfWork.PaymentConfirmation.Update(paymentConfirmation);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!PaymentConfirmationExists(id))
                if (!await PaymentConfirmationExists(id))
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



        // POST: api/PaymentConfirmation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PaymentConfirmation>> PostPaymentConfirmation(PaymentConfirmation paymentConfirmation)
        {
            //Refactored
            // _context.PaymentConfirmation.Add(paymentConfirmation);
            //await _context.SaveChangesAsync();

            await _unitOfWork.PaymentConfirmation.Insert(paymentConfirmation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPaymentConfirmation", new { id = paymentConfirmation.Id }, paymentConfirmation);
        }

        // DELETE: api/PaymentConfirmation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentConfirmation(int id)
        {
            //Refactored
            //var paymentConfirmation = await _context.PaymentConfirmation.FindAsync(id);
            var paymentConfirmation = await _unitOfWork.PaymentConfirmation.Get(q => q.Id == id);
            if (paymentConfirmation == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.PaymentConfirmation.Remove(paymentConfirmation);
            //await _context.SaveChangesAsync();

            await _unitOfWork.PaymentConfirmation.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        // private bool PaymentConfirmationExists(int id)
        private async Task<bool> PaymentConfirmationExists(int id)
        {
            //Refactored
            // return _context.PaymentConfirmation.Any(e => e.Id == id);

            var paymentConfirmation = await _unitOfWork.PaymentConfirmation.Get(q => q.Id == id);
            return paymentConfirmation != null;

        }
    }
}

