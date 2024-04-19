using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TomogotchiP1.Models;
using TomogotchiP1.Data;
using TomogotchiP1.Services;

[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    private readonly PetService _petService;

    public PetsController(PetService petService)
    {
        _petService = petService;
    }

    // other CRUD operations here

    // Post a new pet using the PetServices method CreatePetAsync
    [HttpPost]
    public async Task<ActionResult<Pet>> PostPet(Pet pet)
    {
        await _petService.CreatePetAsync(pet);
        return CreatedAtAction("GetPet", new { id = pet.Id }, pet);
    }

        [HttpGet("{id}")]
    public async Task<ActionResult<Pet>> GetPet(int id)
    {
        var pet = await _petService.GetPetByIdAsync(id);
        if (pet == null)
        {
            return NotFound();
        }
        return pet;
    }

    //Get all pets using the PetServices method GetAllPetsAsync
    [HttpGet]
    public async Task<IEnumerable<Pet>> GetPets()
    {
        return await _petService.GetAllPetsAsync();
    }



    [HttpPost("feed/{id}")]
    public async Task<IActionResult> FeedPet(int id)
    {
        await _petService.FeedPetAsync(id);
        return NoContent();
    }

    [HttpPost("clean/{id}")]
    public async Task<IActionResult> CleanPet(int id)
    {
        await _petService.CleanPetAsync(id);
        return NoContent();
    }

    [HttpPost("play/{id}")]
    public async Task<IActionResult> PlayWithPet(int id)
    {
        await _petService.PlayWithPetAsync(id);
        return NoContent();
    }
}
