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
    public class VehicleBookingController : ControllerBase
    {

        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //private VehicleBookingController(ApplicationDbContext context)
        public VehicleBookingController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/VehicleBooking
        [HttpGet]
        //Refactored
        // public async Task<ActionResult<IEnumerable<VehicleBooking>>> GetVehicleBooking()
        public async Task<IActionResult> GetVehicleBooking()
        {

            //Refactored
            //return await _context.VehicleBooking.ToListAsync();
            var vehicleBooking = await _unitOfWork.VehicleBookings.GetAll(includes: q => q.Include(x => x.TypeOfVehicle).Include(x => x.Price));
            return Ok(vehicleBooking);
        }

        // GET: api/VehicleBooking/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<VehicleBooking>> GetVehicleBooking(int id)
        public async Task<IActionResult> GetVehicleBooking(int id)
        {
            //Refactored
            //var vehicleBooking = await _context.VehicleBooking.FindAsync(id);
            var vehicleBooking = await _unitOfWork.VehicleBookings.Get(q => q.Id == id);

            if (vehicleBooking == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(vehicleBooking);
        }

        // PUT: api/VehicleBooking/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleBooking(int id, VehicleBooking vehicleBooking)
        {
            if (id != vehicleBooking.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(vehicleBooking).State = EntityState.Modified;
            _unitOfWork.VehicleBookings.Update(vehicleBooking);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!VehicleBookingExists(id))
                if (!await VehicleBookingExists(id))
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



        // POST: api/VehicleBooking
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleBooking>> PostVehicleBooking(VehicleBooking vehicleBooking)
        {
            //Refactored
            // _context.VehicleBooking.Add(vehicleBooking);
            //await _context.SaveChangesAsync();

            await _unitOfWork.VehicleBookings.Insert(vehicleBooking);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicleBooking", new { id = vehicleBooking.Id }, vehicleBooking);
        }

        // DELETE: api/VehicleBooking/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleBooking(int id)
        {
            //Refactored
            //var vehicleBooking = await _context.VehicleBooking.FindAsync(id);
            var vehicleBooking = await _unitOfWork.VehicleBookings.Get(q => q.Id == id);
            if (vehicleBooking == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.VehicleBooking.Remove(vehicleBooking);
            //await _context.SaveChangesAsync();

            await _unitOfWork.VehicleBookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        // private bool VehicleBookingExists(int id)
        private async Task<bool> VehicleBookingExists(int id)
        {
            //Refactored
            // return _context.VehicleBooking.Any(e => e.Id == id);

            var vehicleBooking = await _unitOfWork.VehicleBookings.Get(q => q.Id == id);
            return vehicleBooking != null;

        }
    }
}
