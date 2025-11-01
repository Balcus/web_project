namespace Api.DataAccess.Models
{
    public class User : Entity<int>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PasswordHash { get; set; }
        public string? AddressLine { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        public string? StripeCustomerId { get; set; }
        public string? StripePaymentMethodId { get; set; }
        public decimal TotalDonated { get; set; }
        public bool WantsReceiptEmails { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}