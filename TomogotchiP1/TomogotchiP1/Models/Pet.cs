using System.ComponentModel.DataAnnotations;

namespace TomogotchiP1.Models
{
    public enum HealthStatus
    {
        Healthy,
        Sick,
        Critical
    }

    public enum LifeStage
    {
        Egg,
        Baby,
        Child,
        Teen,
        Adult,
        Senior
    }

    public class Pet
    {
        [Key] // This data annotation marks the following property as a primary key.
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        public LifeStage LifeStage { get; set; }

        // Basic needs
        public int HungerLevel { get; set; }
        public int Cleanliness { get; set; }
        public int Happiness { get; set; }

        // Health and well-being
        public HealthStatus HealthStatus { get; set; }

        // Timestamps for last actions performed
        public DateTime LastFed { get; set; }
        public DateTime LastCleaned { get; set; }
        public DateTime LastPlayedWith { get; set; }

        // To track the age and growth of the pet.
        public DateTime BirthDate { get; set; }

        // Methods for updating the pet's state could be included here or managed by a service.
    }
}

