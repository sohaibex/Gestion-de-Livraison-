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
    public class ClientProesController : ControllerBase
    {
        private readonly gestion_livraisonContext _context;

        public ClientProesController(gestion_livraisonContext context)
        {
            _context = context;
        }

        // GET: api/ClientProes
        [HttpGet]
        public IEnumerable<ClientPro> GetClientProes()
        {

            return _context.ClientProes;
        }

        // GET: api/ClientProes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientPro([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clientPro = await _context.ClientProes.FindAsync(id);

            if (clientPro == null)
            {
                return NotFound();
            }

            return Ok(clientPro);
        }

        // PUT: api/ClientProes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientPro([FromRoute] int id, [FromBody] ClientPro clientPro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientPro.IdClientpro)
            {
                return BadRequest();
            }

            _context.Entry(clientPro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientProExists(id))
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

        // POST: api/ClientProes
        [HttpPost]
        public async Task<IActionResult> PostClientPro([FromBody] ClientPro clientPro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ClientProes.Add(clientPro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientPro", new { id = clientPro.IdClientpro }, clientPro);
        }

        // DELETE: api/ClientProes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientPro([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clientPro = await _context.ClientProes.FindAsync(id);
            if (clientPro == null)
            {
                return NotFound();
            }

            _context.ClientProes.Remove(clientPro);
            await _context.SaveChangesAsync();

            return Ok(clientPro);
        }

        private bool ClientProExists(int id)
        {
            return _context.ClientProes.Any(e => e.IdClientpro == id);
        }
    }
}