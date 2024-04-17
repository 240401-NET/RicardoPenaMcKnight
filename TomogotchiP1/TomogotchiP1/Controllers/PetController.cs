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
}
