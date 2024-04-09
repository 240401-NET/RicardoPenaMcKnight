using System.ComponentModel.DataAnnotations;

namespace TomogotchiP1.Models
{
    public class Pet
    {
        [Key] // This data annotation marks the following property as a primary key
        public int Id { get; set; }

        // Other properties for Pet
    }
}
