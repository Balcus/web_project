using Api.DataAccess.Enums;

namespace Api.DataAccess.Models
{
    public class Animal : Entity<int>
    {
        public required string Name { get; set; }
        public required Species Species { get; set; }
        public string? Breed { get; set; }
        public int Age { get; set; }
        public Gender? Gender { get; set; }

        public bool IsVaccinated { get; set; }
        public bool IsNeutered { get; set; }
        public string? AdditionalNotes { get; set; }
        public int AddedByUserId { get; set; }

        public AnimalStatus AdoptionStatus { get; set; }
        public DateTime DateArrived { get; set; }
        public int? ShelterId { get; set; }
        
        public List<Image> Images { get; set; } = [];
        public User? AddedByUser { get; set; }
        public Shelter? FromShelter { get; set; }
    }
}