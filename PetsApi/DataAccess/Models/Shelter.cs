namespace Api.DataAccess.Models
{
    public class Shelter : Entity<int>
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public string? AddressLine { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public List<Image> Images { get; set; } = [];
    }
}