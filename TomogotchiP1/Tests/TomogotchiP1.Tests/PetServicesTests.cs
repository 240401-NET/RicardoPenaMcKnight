using Microsoft.EntityFrameworkCore;
using TomogotchiP1.Models;
using TomogotchiP1.Services;
using TomogotchiP1.Data;
using Moq;

public class PetServiceTests : IDisposable
{
    private readonly AppDbContext _context;
    private readonly PetService _petService;

    public PetServiceTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb") // Ensure each test method has a fresh instance by using a unique name or by clearing data.
            .Options;
        
        _context = new AppDbContext(options);
        _petService = new PetService(_context);

        // Seed the database
        _context.Pets.Add(new Pet { Id = 1, Name = "Fido", HungerLevel = 10 });
        _context.SaveChanges();
    }

    [Fact]
    public async Task FeedPet_DecreasesHungerLevel()
    {
        await _petService.FeedPetAsync(1);

        var pet = await _context.Pets.FindAsync(1);
        Assert.True(pet.HungerLevel < 10); // Assuming feeding reduces hunger level
    }

    [Fact]
    public async Task GetAllPetsAsync_ReturnsAllPets()
    {
        var pets = await _petService.GetAllPetsAsync();
        Assert.NotNull(pets);
        Assert.Equal(1, pets.Count()); // Assuming you have seeded one pet in the setup
    }

    [Fact]
    public async Task GetPetByIdAsync_ReturnsCorrectPet()
    {
        var pet = await _petService.GetPetByIdAsync(1);
        Assert.NotNull(pet);
        Assert.Equal("Fido", pet.Name);
    }

    [Fact]
    public async Task GetPetByIdAsync_ThrowsWhenPetNotFound()
    {
        await Assert.ThrowsAsync<Exception>(() => _petService.GetPetByIdAsync(999));
    }

    [Fact]
    public async Task CleanPet_IncreasesCleanliness()
    {
        var initialCleanliness = _context.Pets.Find(1).Cleanliness;
        await _petService.CleanPetAsync(1);
        var updatedPet = await _context.Pets.FindAsync(1);

        Assert.True(updatedPet.Cleanliness > initialCleanliness);
    }

    [Fact]
    public async Task PlayWithPet_IncreasesHappiness()
    {
        var initialHappiness = _context.Pets.Find(1).Happiness;
        await _petService.PlayWithPetAsync(1);
        var updatedPet = await _context.Pets.FindAsync(1);

        Assert.True(updatedPet.Happiness > initialHappiness);
    }

    [Fact]
    public async Task NeglectPet_UpdatesHealthStatusToSick()
    {
        // Simulate neglect by not updating the pet's needs for a prolonged time
        var pet = await _petService.GetPetByIdAsync(1);
        pet.LastFed = DateTime.UtcNow.AddDays(-5); // Not fed for 5 days
        await _petService.CheckPetHealthAsync(1);
    
        Assert.Equal(HealthStatus.Sick, pet.HealthStatus);
    }



    public void Dispose()
    {
        _context.Database.EnsureDeleted(); // Clean up the in-memory database
    }
}


