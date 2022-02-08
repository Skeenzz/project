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
    public class FlightsController : ControllerBase
    {

        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //private FlightsController(ApplicationDbContext context)
        public FlightsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/Flights
        [HttpGet]
        //Refactored
        // public async Task<ActionResult<IEnumerable<Flights>>> GetFlights()
        public async Task<IActionResult> GetFlights()
        {

            //Refactored
            //return await _context.Flights.ToListAsync();
            var flight = await _unitOfWork.Flights.GetAll();
            return Ok(flight);
        }

        // GET: api/Flights/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Flights>> GetFlights(int id)
        public async Task<IActionResult> GetFlights(int id)
        {
            //Refactored
            //var flight = await _context.Flights.FindAsync(id);
            var flight = await _unitOfWork.Flights.Get(q => q.Id == id);

            if (flight == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(flight);
        }

        // PUT: api/Flights/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlights(int id, Flights flight)
        {
            if (id != flight.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(flight).State = EntityState.Modified;
            _unitOfWork.Flights.Update(flight);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!FlightsExists(id))
                if (!await FlightsExists(id))
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



        // POST: api/Flights
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Flights>> PostFlights(Flights flight)
        {
            //Refactored
            // _context.Flights.Add(flight);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Flights.Insert(flight);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetFlights", new { id = flight.Id }, flight);
        }

        // DELETE: api/Flights/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlights(int id)
        {
            //Refactored
            //var flight = await _context.Flights.FindAsync(id);
            var flight = await _unitOfWork.Flights.Get(q => q.Id == id);
            if (flight == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Flights.Remove(flight);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Flights.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        // private bool FlightsExists(int id)
        private async Task<bool> FlightsExists(int id)
        {
            //Refactored
            // return _context.Flights.Any(e => e.Id == id);

            var flight = await _unitOfWork.Flights.Get(q => q.Id == id);
            return flight != null;

        }
    }
}
