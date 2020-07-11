using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LivraisonWebAPi.Models;

namespace LivraisonWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencesController : ControllerBase
    {
        private readonly gestion_livraisonContext _context;

        public AgencesController(gestion_livraisonContext context)
        {
            _context = context;
        }

        // GET: api/Agences
        [HttpGet]
        public IEnumerable<Agence> GetAgences()
        {
            return _context.Agences;
        }



        // GET: api/Agences/5  AgenceDetails
        //[HttpGet("GetAgenceDetails/{id}")]
        //public async Task<IActionResult> GetAgenceDetails([FromRoute] int id)
        //{

        //    var agence = _context.Agences
        //        .Include(ag => ag.Livreurs)
        //    .Where(ag => ag.IdAgence == id)
        //    .FirstOrDefault();

            //var agence = await _context.Agences.SingleAsync(ag => ag.IdAgence == id);
            //_context.Entry(agence)
            //  .Collection(ag => ag.Commandes)
            //  .Load();



        //    if (agence == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(agence);
        //}



        // GET: api/Agences/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAgence([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var agence = await _context.Agences.FindAsync(id);

            if (agence == null)
            {
                return NotFound();
            }

            return Ok(agence);
        }

        // PUT: api/Agences/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgence([FromRoute] int id, [FromBody] Agence agence)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != agence.IdAgence)
            {
                return BadRequest();
            }

            _context.Entry(agence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgenceExists(id))
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

        // POST: api/Agences
        [HttpPost]
        public async Task<IActionResult> PostAgence([FromBody] Agence agence)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Agences.Add(agence);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgence", new { id = agence.IdAgence }, agence);
        }

        // DELETE: api/Agences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgence([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var agence = await _context.Agences.FindAsync(id);
            if (agence == null)
            {
                return NotFound();
            }

            _context.Agences.Remove(agence);
            await _context.SaveChangesAsync();

            return Ok(agence);
        }

        private bool AgenceExists(int id)
        {
            return _context.Agences.Any(e => e.IdAgence == id);
        }
    }
}