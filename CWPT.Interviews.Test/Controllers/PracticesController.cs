using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWPT.Interviews.Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PracticesController : ControllerBase
    {
        private readonly ILogger<PracticesController> _logger;
        private readonly PracticeContext _context;

        public PracticesController(
            ILogger<PracticesController> logger,
            PracticeContext context)
        {
            _logger = logger;
            _context = context;
        }



        //Get all Practises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Practice>>> Get()
        {
            return await _context.Practices
               .Select(x => (x))
               .ToListAsync();
        }


        //Get Practise by ID
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Practice>> GetById(int id)
        {
            var practice = await _context.Practices.FindAsync(id);

            if (practice == null)
            {
                return NotFound();
            }

            return (Practice)practice;
        }

        //Create a practise
        [HttpPost]
        public async Task<ActionResult<Practice>> Create(Practice practice)
        {
            var practise = new Practice
            {

                Name = practice.Name,
                AddressLine1 = practice.AddressLine1,
                AddressLine2 = practice.AddressLine2,
                AddressLine3 = practice.AddressLine3,
                Postcode = practice.Postcode,
                Longitude = practice.Longitude,
                Latitude = practice.Latitude,

            };

            _context.Practices.Add(practice);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetById),
                new { id = practice.Id },
                (practice));
        }

        //Put request for Practise
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPractise(long id, Practice practice)
        {
            if (id != practice.Id)
            {
                return BadRequest();
            }

            _context.Entry(practice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PracticeExists(id))
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

        //Check if practise exists
        private bool PracticeExists(long id)
        {
            return _context.Practices.Any(e => e.Id == id);
        }

        
    }
}
