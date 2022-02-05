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
    public class FlightBookingController : ControllerBase
    {

        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //private BookingDetailsController(ApplicationDbContext context)
        public FlightBookingController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/BookingDetails
        [HttpGet]
        //Refactored
        // public async Task<ActionResult<IEnumerable<BookingDetails>>> GetBookingDetails()
        public async Task<IActionResult> GetFlightBookings()
        {

            //Refactored
            //return await _context.BookingDetails.ToListAsync();
            var flightBookings = await _unitOfWork.FlightBookings.GetAll(includes: q => q.Include(x =>x.LeavingFrom).Include(x => x.GoingTo).Include(x => x.Price)); 
            return Ok(flightBookings);
        }

        // GET: api/BookingDetails/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<BookingDetails>> GetBookingDetails(int id)
        public async Task<IActionResult> GetFlightBookings(int id)
        {
            //Refactored
            //var bookingDetail = await _context.BookingDetails.FindAsync(id);
            var flightBookings = await _unitOfWork.FlightBookings.Get(q => q.Id == id);

            if (flightBookings == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(flightBookings);
        }

        // PUT: api/BookingDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlightBookings(int id, FlightBooking flightBookings)
        {
            if (id != flightBookings.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(bookingDetail).State = EntityState.Modified;
            _unitOfWork.FlightBookings.Update(flightBookings);

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
                if (!await FlightBookingsExists(id))
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
        public async Task<ActionResult<FlightBooking>> PostFlightBookings(FlightBooking flightBookings)
        {
            //Refactored
            // _context.BookingDetails.Add(bookingDetail);
            //await _context.SaveChangesAsync();

            await _unitOfWork.FlightBookings.Insert(flightBookings);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBookings", new { id = flightBookings.Id }, flightBookings);
        }

        // DELETE: api/BookingDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlightBookings(int id)
        {
            //Refactored
            //var bookingDetail = await _context.BookingDetails.FindAsync(id);
            var flightBookings = await _unitOfWork.FlightBookings.Get(q => q.Id == id);
            if (flightBookings == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.BookingDetails.Remove(bookingDetail);
            //await _context.SaveChangesAsync();

            await _unitOfWork.FlightBookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        // private bool BookingDetailsExists(int id)
        private async Task<bool> FlightBookingsExists(int id)
        {
            //Refactored
            // return _context.BookingDetails.Any(e => e.Id == id);

            var flightBookings = await _unitOfWork.FlightBookings.Get(q => q.Id == id);
            return flightBookings != null;

        }
    }
}