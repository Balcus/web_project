namespace Api.DataAccess.Models;

public class Donation : Entity<int>
{
    public int UserId { get; set; }
    public float AmountDonated { get; set; }
}