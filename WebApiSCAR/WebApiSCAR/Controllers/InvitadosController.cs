using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiSCAR.Models;

namespace WebApiSCAR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitadosController : ControllerBase
    {
        private readonly SCARContext _context;

        public InvitadosController(SCARContext context)
        {
            _context = context;
        }

        // GET: api/Invitados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invitado>>> GetInvitados()
        {
            return await _context.Invitados.ToListAsync();
        }

        // GET: api/Invitados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Invitado>> GetInvitado(int id)
        {
            var invitado = await _context.Invitados.FindAsync(id);

            if (invitado == null)
            {
                return NotFound();
            }

            return invitado;
        }

        // PUT: api/Invitados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvitado(int id, Invitado invitado)
        {
            if (id != invitado.Id)
            {
                return BadRequest();
            }

            _context.Entry(invitado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvitadoExists(id))
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

        // POST: api/Invitados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Invitado>> PostInvitado(Invitado invitado)
        {
            _context.Invitados.Add(invitado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvitado", new { id = invitado.Id }, invitado);
        }

        // DELETE: api/Invitados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvitado(int id)
        {
            var invitado = await _context.Invitados.FindAsync(id);
            if (invitado == null)
            {
                return NotFound();
            }

            _context.Invitados.Remove(invitado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvitadoExists(int id)
        {
            return _context.Invitados.Any(e => e.Id == id);
        }
    }
}
