using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dacodes_APICORE.Models;

namespace dacodes_APICORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lesson_scoresController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public Lesson_scoresController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Lesson_scores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lesson_score>>> GetLesson_scores()
        {
            return await _context.Lesson_scores.ToListAsync();
        }

        // GET: api/Lesson_scores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lesson_score>> GetLesson_score(Guid id)
        {
            var lesson_score = await _context.Lesson_scores.FindAsync(id);

            if (lesson_score == null)
            {
                return NotFound();
            }

            return lesson_score;
        }

        // PUT: api/Lesson_scores/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLesson_score(Guid id, Lesson_score lesson_score)
        {
            if (id != lesson_score.Id)
            {
                return BadRequest();
            }

            _context.Entry(lesson_score).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Lesson_scoreExists(id))
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

        // POST: api/Lesson_scores
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Lesson_score>> PostLesson_score(Lesson_score lesson_score)
        {
            _context.Lesson_scores.Add(lesson_score);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLesson_score", new { id = lesson_score.Id }, lesson_score);
        }

        // DELETE: api/Lesson_scores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Lesson_score>> DeleteLesson_score(Guid id)
        {
            var lesson_score = await _context.Lesson_scores.FindAsync(id);
            if (lesson_score == null)
            {
                return NotFound();
            }

            _context.Lesson_scores.Remove(lesson_score);
            await _context.SaveChangesAsync();

            return lesson_score;
        }

        private bool Lesson_scoreExists(Guid id)
        {
            return _context.Lesson_scores.Any(e => e.Id == id);
        }
    }
}
