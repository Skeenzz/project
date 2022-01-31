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
    public class TypeOfVehicleController : ControllerBase
    {

        //Refactored
        //private readonly ApplicationDbContext context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //private TypeOfVehiclesController(ApplicationDbContext context)
        public TypeOfVehicleController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/TypeOfVehicles
        [HttpGet]
        //Refactored
        // public async Task<ActionResult<IEnumerable<TypeOfVehicle>>> GetTypeOfVehicles()
        public async Task<IActionResult> GetTypeOfVehicles()
        {

            //Refactored
            //return await _context.TypeOfVehicles.ToListAsync();
            var typeOfVehicle = await _unitOfWork.TypeOfVehicle.GetAll();
            return Ok(typeOfVehicle);
        }

        // GET: api/TypeOfVehicles/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<TypeOfVehicle>> GetTypeOfVehicle(int id)
        public async Task<IActionResult> GetTypeOfVehicles(int id)
        {
            //Refactored
            //var typeOfVehicle = await _context.TypeOfVehicle.FindAsync(id);
            var typeOfVehicle = await _unitOfWork.TypeOfVehicle.Get(q => q.Id == id);

            if (typeOfVehicle == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(typeOfVehicle);
        }

        // PUT: api/TypeOfVehicle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeOfVehicles(int id, TypeOfVehicle typeOfVehicle)
        {
            if (id != typeOfVehicle.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(typeOfVehicle).State = EntityState.Modified;
            _unitOfWork.TypeOfVehicle.Update(typeOfVehicle);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!TypeOfVehicleExists(id))
                if (!await TypeOfVehicleExists(id))
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



        // POST: api/TypeOfVehicle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeOfVehicle>> PostTypeOfVehicles(TypeOfVehicle typeOfVehicle)
        {
            //Refactored
            // _context.TypeOfVehicle.Add(typeOfVehicle);
            //await _context.SaveChangesAsync();

            await _unitOfWork.TypeOfVehicle.Insert(typeOfVehicle);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetTypeOfVehicles", new { id = typeOfVehicle.Id }, typeOfVehicle);
        }

        // DELETE: api/TypeOfVehicle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeOfVehicles(int id)
        {
            //Refactored
            //var typeOfVehicle = await _context.TypeOfVehicle.FindAsync(id);
            var typeOfVehicle = await _unitOfWork.TypeOfVehicle.Get(q => q.Id == id);
            if (typeOfVehicle == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.TypeOfVehicle.Remove(typeOfVehicle);
            //await _context.SaveChangesAsync();

            await _unitOfWork.TypeOfVehicle.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        // private bool TypeOfVehicleExists(int id)
        private async Task<bool> TypeOfVehicleExists(int id)
        {
            //Refactored
            // return _context.TypeOfVehicle.Any(e => e.Id == id);

            var typeOfVehicle = await _unitOfWork.TypeOfVehicle.Get(q => q.Id == id);
            return typeOfVehicle != null;

        }
    }
}
