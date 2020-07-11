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
    public class LivreursController : ControllerBase
    {
        private readonly gestion_livraisonContext _context;

        public LivreursController(gestion_livraisonContext context)
        {
            _context = context;
        }

        // GET: api/Livreurs
        [HttpGet]
        public IEnumerable<Livreur> GetLivreurs()
        {
            return _context.Livreurs;
        }

        // GET: api/Livreurs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLivreur([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var livreur = await _context.Livreurs.FindAsync(id);

            if (livreur == null)
            {
                return NotFound();
            }

            return Ok(livreur);
        }

        // PUT: api/Livreurs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLivreur([FromRoute] int id, [FromBody] Livreur livreur)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != livreur.IdLivreur)
            {
                return BadRequest();
            }

            _context.Entry(livreur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivreurExists(id))
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

        // POST: api/Livreurs
        [HttpPost]
        public async Task<IActionResult> PostLivreur([FromBody] Livreur livreur)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Livreurs.Add(livreur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLivreur", new { id = livreur.IdLivreur }, livreur);
        }

        // DELETE: api/Livreurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLivreur([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var livreur = await _context.Livreurs.FindAsync(id);
            if (livreur == null)
            {
                return NotFound();
            }

            _context.Livreurs.Remove(livreur);
            await _context.SaveChangesAsync();

            return Ok(livreur);
        }

        private bool LivreurExists(int id)
        {
            return _context.Livreurs.Any(e => e.IdLivreur == id);
        }
    }
}