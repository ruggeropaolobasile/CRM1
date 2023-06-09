using CRM1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InteractionsController : ControllerBase
    {
        private readonly CRMContext _context;

        public InteractionsController(CRMContext context)
        {
            _context = context;
        }

        // GET: api/Interactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interaction>>> GetInteractions()
        {
            return await _context.Interactions.ToListAsync();
        }

        // GET: api/Interactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Interaction>> GetInteraction(int id)
        {
            var interaction = await _context.Interactions.FindAsync(id);

            if (interaction == null)
            {
                return NotFound();
            }

            return interaction;
        }

        // POST: api/Interactions
        [HttpPost]
        public async Task<ActionResult<Interaction>> CreateInteraction(Interaction interaction)
        {
            _context.Interactions.Add(interaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInteraction), new { id = interaction.Id }, interaction);
        }

        // PUT: api/Interactions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInteraction(int id, Interaction interaction)
        {
            if (id != interaction.Id)
            {
                return BadRequest();
            }

            _context.Entry(interaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InteractionExists(id))
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

        // DELETE: api/Interactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInteraction(int id)
        {
            var interaction = await _context.Interactions.FindAsync(id);
            if (interaction == null)
            {
                return NotFound();
            }

            _context.Interactions.Remove(interaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InteractionExists(int id)
        {
            return _context.Interactions.Any(e => e.Id == id);
        }
    }
}
