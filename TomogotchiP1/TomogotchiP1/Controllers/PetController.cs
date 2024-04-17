using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TomogotchiP1.Models;
using TomogotchiP1.Data;

[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    private readonly AppDbContext _context;

    public PetsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Pets
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
    {
        return await _context.Pets.ToListAsync();
    }

    // other CRUD operations here

        // GET: api/Pets/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Pet>> GetPet(int id)
    {
        var pet = await _context.Pets.FindAsync(id);
        if (pet == null)
        {
            return NotFound();
        }
        return pet;
    }

    // POST: api/Pets
    [HttpPost]
    public async Task<ActionResult<Pet>> PostPet(Pet pet)
    {
        _context.Pets.Add(pet);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetPet", new { id = pet.Id }, pet);
    }

    // Additional methods for PUT, DELETE etc. can be added here.
}
