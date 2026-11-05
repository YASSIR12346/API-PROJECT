using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PROJECT.Models;
using API_PROJECT.Database;

[Route("api/[controller]")]
[ApiController]
public class VideoGamesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public VideoGamesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/VideoGame
    [HttpGet]
    public async Task<ActionResult<IEnumerable<VideoGame>>> GetVideoGame()
    {
        return await _context.VideoGames.ToListAsync();
    }

    // GET: api/VideoGame/5
    [HttpGet("{id}")]
    public async Task<ActionResult<VideoGame>> GetVideoGame(int id)
    {
        var videogame = await _context.VideoGames.FindAsync(id);

        if (videogame == null)
        {
            return NotFound();
        }

        return videogame;
    }

    // PUT: api/VideoGame/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutVideoGame(int? id, VideoGame videogame)
    {
        if (id != videogame.Id)
        {
            return BadRequest();
        }

        _context.Entry(videogame).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!VideoGameExists(id))
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

    // POST: api/VideoGame
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<VideoGame>> PostVideoGame(VideoGame videogame)
    {
        _context.VideoGames.Add(videogame);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetVideoGame", new { id = videogame.Id }, videogame);
    }

    // DELETE: api/VideoGame/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteVideoGame(int? id)
    {
        var videogame = await _context.VideoGames.FindAsync(id);
        if (videogame == null)
        {
            return NotFound();
        }

        _context.VideoGames.Remove(videogame);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool VideoGameExists(int? id)
    {
        return _context.VideoGames.Any(e => e.Id == id);
    }
}
