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
    public class ReviewsController : ControllerBase
    {

        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //private FlightsController(ApplicationDbContext context)
        public ReviewsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/Reviews
        [HttpGet]
        //Refactored
        // public async Task<ActionResult<IEnumerable<Reviews>>> GetFlights()
        public async Task<IActionResult> GetFlights()
        {

            //Refactored
            //return await _context.Reviews.ToListAsync();
            var review = await _unitOfWork.Reviews.GetAll();
            return Ok(review);
        }

        // GET: api/Reviews/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Reviews>> GetFlights(int id)
        public async Task<IActionResult> GetFlights(int id)
        {
            //Refactored
            //var review = await _context.Reviews.FindAsync(id);
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);

            if (review == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(review);
        }

        // PUT: api/Reviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlights(int id, Reviews review)
        {
            if (id != review.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(review).State = EntityState.Modified;
            _unitOfWork.Reviews.Update(review);

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



        // POST: api/Reviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reviews>> PostFlights(Reviews review)
        {
            //Refactored
            // _context.Reviews.Add(review);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Reviews.Insert(review);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetFlights", new { id = review.Id }, review);
        }

        // DELETE: api/Reviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlights(int id)
        {
            //Refactored
            //var review = await _context.Reviews.FindAsync(id);
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Reviews.Remove(review);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Reviews.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        // private bool FlightsExists(int id)
        private async Task<bool> FlightsExists(int id)
        {
            //Refactored
            // return _context.Reviews.Any(e => e.Id == id);

            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
            return review != null;

        }
    }
}

