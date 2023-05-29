using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectTennis.Models;

namespace ProjectTennis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TennisController : ControllerBase 
    {
        private readonly TodoContext _context;

        public TennisController(TodoContext context) 
        {
            _context = context;
        }

        // GET: api/Tennis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TennisDTO>>> GetTodoItems() 
        {
            return await _context.TodoItems
                .Select(x => TennisDTO(x))
                .ToListAsync();
        }

        // GET: api/Tennis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TennisDTO>> GetTennis(long id) 
        {
            var tennis = await _context.TodoItems.FindAsync(id);

            if (tennis == null) 
            {
                return NotFound();
            }

            return TennisDTO(tennis);
        }

        // PUT: api/Tennis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTennis(long id, TennisDTO tennisDTO) 
        {
            if (id != tennisDTO.Id) 
            {
                return BadRequest();
            }

            var tennis = await _context.TodoItems.FindAsync(id);
            if (tennis == null) 
            {
                return NotFound();
            }
            tennis.Name = tennisDTO.Name;
            tennis.IsComplete = tennisDTO.IsComplete;

            try 
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!TennisExists(id))
            {
                return NotFound();
            }
            return NoContent();
        }

        // POST: api/Tennis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TennisDTO>> PostTennis(TennisDTO tennisDTO)
        {
            var tennis = new tennis
            {
                IsComplete = tennisDTO.IsComplete,
                Name = tennisDTO.Name
            };

            _context.TodoItems.Add(tennis);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTennis), new { id = tennis.Id }, TennisDTO(tennis));
        }

        // DELETE: api/Tennis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTennis(long id)
        {
            var tennis = await _context.TodoItems.FindAsync(id);
            if (tennis == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(tennis);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TennisExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
        private static TennisDTO TennisDTO(tennis tennis) =>
            new TennisDTO
            {
             Id = tennis.Id,
             Name = tennis.Name,
             IsComplete = tennis.IsComplete,
            };
    }
}
    