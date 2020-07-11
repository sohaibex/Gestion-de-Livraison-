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
    public class ClientParsController : ControllerBase
    {
        private readonly gestion_livraisonContext _context;

        public ClientParsController(gestion_livraisonContext context)
        {
            _context = context;
        }

        // GET: api/ClientPars
        [HttpGet]
        public IEnumerable<ClientPar> GetClientPars()
        {
            return _context.ClientPars;
        }




        // GET: api/ClientPars
        [HttpGet("GetAgenceDetails")]
        public async Task<IActionResult> GetDetailClientPars()
        {
            var client = from cl in _context.ClientPars
                         join v in _context.Villes
                         on cl.IdVille equals v.Id
                         select new
                         {
                             cl.Idclpar,
                             cl.Nom,
                             cl.Prenom,
                             cl.Dtn,
                             cl.Adresse,
                             cl.Tel,
                             v.NomVille,
                             cl.Email,
                             cl.Mdp
                         };
            return Ok(client);
        }

        // GET: api/ClientPars/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientPar([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clientPar = await _context.ClientPars.FindAsync(id);

            if (clientPar == null)
            {
                return NotFound();
            }

            return Ok(clientPar);
        }

        // PUT: api/ClientPars/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientPar([FromRoute] int id, [FromBody] ClientPar clientPar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientPar.Idclpar)
            {
                return BadRequest();
            }

            _context.Entry(clientPar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientParExists(id))
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

        // POST: api/ClientPars
        [HttpPost]
        public async Task<IActionResult>PostClientPar([FromBody] ClientPar clientPar)
        {
          
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ClientPars.Add(clientPar);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetClientPar", new { id = clientPar.Idclpar }, clientPar);
        }

        // DELETE: api/ClientPars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientPar([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clientPar = await _context.ClientPars.FindAsync(id);
            if (clientPar == null)
            {
                return NotFound();
            }

            _context.ClientPars.Remove(clientPar);
            await _context.SaveChangesAsync();

            return Ok(clientPar);
        }

        private bool ClientParExists(int id)
        {
            return _context.ClientPars.Any(e => e.Idclpar == id);
        }
    }
}