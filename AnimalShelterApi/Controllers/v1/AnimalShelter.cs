
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;
using Microsoft.AspNetCore.JsonPatch;


namespace AnimalShelterApi.Controllers.v1
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]

  public class SheltersController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public SheltersController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Shelter>>> Get()//string comment, string group, string userName)
    {
      IQueryable<Shelter> query = _db.Shelters.AsQueryable();

      if (comment != null)
      {
        query = query.Where(entry => entry.Comment == comment);
      }

      if (group != null)
      {
        query = query.Where(entry => entry.Group == group);
      }

      if (userName != null)
      {
        query = query.Where(entry => entry.UserName == userName);
      }
      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Shelter>> GetShelter(int id)
    {
      Shelter shelter = await _db.Shelters.FindAsync(id);

      if (shelter == null)
      {
        return NotFound();
      }
      
      return shelter;
    }

    [HttpPost]
    public async Task<ActionResult<Shelter>> Post(Shelter shelter)
    {
      _db.Shelters.Add(shelter);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetShelter), new { id = shelter.ShelterId }, shelter);
    }

    //PUT: api/Shelters/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Shelter shelter)
    {
      if (id != shelter.ShelterId)
      {
        return BadRequest();
      }

      _db.Shelters.Update(shelter);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ShelterExists(id))
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

    private bool ShelterExists(int id)
    {
      return _db.Shelters.Any(e => e.ShelterId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteShelter(int id)
    {
      Shelter shelter = await _db.Shelters.FindAsync(id);
      if (shelter == null)
      {
        return NotFound();
      }

      _db.Shelters.Remove(shelter);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}