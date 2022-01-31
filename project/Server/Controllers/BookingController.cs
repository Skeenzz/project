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
    public class BookingController : ControllerBase
    {

        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //private BookingDetailsController(ApplicationDbContext context)
        public BookingController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/BookingDetails
        [HttpGet]
        //Refactored
        // public async Task<ActionResult<IEnumerable<BookingDetails>>> GetBookingDetails()
        public async Task<IActionResult> GetBooking()
        {

            //Refactored
            //return await _context.BookingDetails.ToListAsync();
            var booking = await _unitOfWork.Booking.GetAll(includes: q => q.Include(x =>x.LeavingFrom).Include(x => x.GoingTo).Include(x => x.Price)); 
            return Ok(booking);
        }

        // GET: api/BookingDetails/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<BookingDetails>> GetBookingDetails(int id)
        public async Task<IActionResult> GetBookings(int id)
        {
            //Refactored
            //var bookingDetail = await _context.BookingDetails.FindAsync(id);
            var booking = await _unitOfWork.Booking.Get(q => q.Id == id);

            if (booking == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(booking);
        }

        // PUT: api/BookingDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(bookingDetail).State = EntityState.Modified;
            _unitOfWork.Booking.Update(booking);

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
                if (!await BookingExists(id))
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
        public async Task<ActionResult<Booking>> PostBookings(Booking booking)
        {
            //Refactored
            // _context.BookingDetails.Add(bookingDetail);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Booking.Insert(booking);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBookings", new { id = booking.Id }, booking);
        }

        // DELETE: api/BookingDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            //Refactored
            //var bookingDetail = await _context.BookingDetails.FindAsync(id);
            var booking = await _unitOfWork.Booking.Get(q => q.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.BookingDetails.Remove(bookingDetail);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Booking.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        // private bool BookingDetailsExists(int id)
        private async Task<bool> BookingExists(int id)
        {
            //Refactored
            // return _context.BookingDetails.Any(e => e.Id == id);

            var booking = await _unitOfWork.Booking.Get(q => q.Id == id);
            return booking != null;

        }
    }
}