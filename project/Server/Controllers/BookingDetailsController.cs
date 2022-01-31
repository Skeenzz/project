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

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingDetailsController : ControllerBase
    {

        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //private BookingDetailsController(ApplicationDbContext context)
        public BookingDetailsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/BookingDetails
        [HttpGet]
        //Refactored
        // public async Task<ActionResult<IEnumerable<BookingDetails>>> GetBookingDetails()
        public async Task<IActionResult> GetBookingDetails()
        {

            //Refactored
            //return await _context.BookingDetails.ToListAsync();
            var bookingDetail = await _unitOfWork.BookingDetails.GetAll(includes: q => q.Include(x =>x.TypeOfVehicle).Include(x =>x.Price)); 
            return Ok(bookingDetail);
        }

        // GET: api/BookingDetails/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<BookingDetails>> GetBookingDetails(int id)
        public async Task<IActionResult> GetBookingDetails(int id)
        {
            //Refactored
            //var bookingDetail = await _context.BookingDetails.FindAsync(id);
            var bookingDetail = await _unitOfWork.BookingDetails.Get(q => q.Id == id);

            if (bookingDetail == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(bookingDetail);
        }

        // PUT: api/BookingDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookingDetails(int id, BookingDetails bookingDetail)
        {
            if (id != bookingDetail.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(bookingDetail).State = EntityState.Modified;
            _unitOfWork.BookingDetails.Update(bookingDetail);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!BookingDetailsExists(id))
                if (!await BookingDetailsExists(id))
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



        // POST: api/BookingDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookingDetails>> PostBookingDetails(BookingDetails bookingDetail)
        {
            //Refactored
            // _context.BookingDetails.Add(bookingDetail);
            //await _context.SaveChangesAsync();

            await _unitOfWork.BookingDetails.Insert(bookingDetail);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBookingDetails", new { id = bookingDetail.Id }, bookingDetail);
        }

        // DELETE: api/BookingDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingDetails(int id)
        {
            //Refactored
            //var bookingDetail = await _context.BookingDetails.FindAsync(id);
            var bookingDetail = await _unitOfWork.BookingDetails.Get(q => q.Id == id);
            if (bookingDetail == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.BookingDetails.Remove(bookingDetail);
            //await _context.SaveChangesAsync();

            await _unitOfWork.BookingDetails.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        // private bool BookingDetailsExists(int id)
        private async Task<bool> BookingDetailsExists(int id)
        {
            //Refactored
            // return _context.BookingDetails.Any(e => e.Id == id);

            var bookingDetail = await _unitOfWork.BookingDetails.Get(q => q.Id == id);
            return bookingDetail != null;

        }
    }
}