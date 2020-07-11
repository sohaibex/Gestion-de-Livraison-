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
    public class CommandesController : ControllerBase
    {
        private readonly gestion_livraisonContext _context;

        public CommandesController(gestion_livraisonContext context)
        {
            _context = context;
        }

        // GET: api/Commandes
        [HttpGet]
        public IEnumerable<Commande> GetCommandes()
        {
            return _context.Commandes;
        }

        // GET: api/Commandes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommande([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commande = await _context.Commandes.FindAsync(id);

            if (commande == null)
            {
                return NotFound();
            }

            return Ok(commande);
        }

        // PUT: api/Commandes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommande([FromRoute] int id, [FromBody] Commande commande)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != commande.IdCommande)
            {
                return BadRequest();
            }

            _context.Entry(commande).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommandeExists(id))
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

        // POST: api/Commandes
        [HttpPost]
        public async Task<IActionResult> PostCommande([FromBody] Commande commande)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Commandes.Add(commande);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommande", new { id = commande.IdCommande }, commande);
        }

        // DELETE: api/Commandes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommande([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commande = await _context.Commandes.FindAsync(id);
            if (commande == null)
            {
                return NotFound();
            }

            _context.Commandes.Remove(commande);
            await _context.SaveChangesAsync();

            return Ok(commande);
        }

        private bool CommandeExists(int id)
        {
            return _context.Commandes.Any(e => e.IdCommande == id);
        }
    }
}