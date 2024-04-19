using TomogotchiP1.Data;
using TomogotchiP1.Models;
using Microsoft.EntityFrameworkCore;

namespace TomogotchiP1.Services;

public class PetService
{
    private readonly AppDbContext _context;

    public PetService(AppDbContext context)
    {
        _context = context;
    }

    // Create a CreatePetAsync Method that will add a new pet to the database
    public async Task CreatePetAsync(Pet pet)
    {
        _context.Pets.Add(pet);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Pet>> GetAllPetsAsync()
    {
        return await _context.Pets.ToListAsync();
    }

    public async Task<Pet> GetPetByIdAsync(int id)
    {
        return await _context.Pets.FirstOrDefaultAsync(p => p.Id == id) ?? throw new Exception("Pet not found");
    }

    public async Task FeedPetAsync(int petId)
    {
        var pet = await GetPetByIdAsync(petId);
        if (pet != null)
        {
            // Business logic to update pet's hunger level
            pet.HungerLevel = Math.Max(0, pet.HungerLevel - 10); // Decrease hunger
            pet.LastFed = DateTime.UtcNow;
            await _context.SaveChangesAsync();
        }
    }

    // Methods for cleaning, playing with the pet, updating health, etc.

        public async Task CleanPetAsync(int petId)
    {
        var pet = await GetPetByIdAsync(petId);
        if (pet == null)
            throw new Exception("Pet not found.");

        pet.Cleanliness += 10; // Increase cleanliness level
        pet.LastCleaned = DateTime.UtcNow;

        _context.Pets.Update(pet);
        await _context.SaveChangesAsync();
    }

    public async Task PlayWithPetAsync(int petId)
    {
        var pet = await GetPetByIdAsync(petId);
        if (pet == null)
            throw new Exception("Pet not found.");

        pet.Happiness += 10; // Increase happiness level
        pet.LastPlayedWith = DateTime.UtcNow;

        _context.Pets.Update(pet);
        await _context.SaveChangesAsync();
    }

    public async Task CheckPetHealthAsync(int petId)
    {
        var pet = await GetPetByIdAsync(petId);
        if (pet == null)
            throw new Exception("Pet not found.");

        // Check if pet has been neglected
        if (DateTime.UtcNow - pet.LastFed > TimeSpan.FromDays(3) || 
            DateTime.UtcNow - pet.LastCleaned > TimeSpan.FromDays(3))
        {
            pet.HealthStatus = HealthStatus.Sick;
        }
        else if (DateTime.UtcNow - pet.LastFed > TimeSpan.FromDays(5) || 
                 DateTime.UtcNow - pet.LastCleaned > TimeSpan.FromDays(5))
        {
            pet.HealthStatus = HealthStatus.Critical;
        }
        else
        {
            pet.HealthStatus = HealthStatus.Healthy; // Default to healthy if not neglected
        }

        _context.Pets.Update(pet);
        await _context.SaveChangesAsync();
    }
}
