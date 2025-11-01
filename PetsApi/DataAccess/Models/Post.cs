namespace Api.DataAccess.Models;

public class Post : Entity<int>
{
    public int UserId { get; set; }
    public required string Title { get; set; }
    public DateTime CreationDate { get; set; }
    public string? Description { get; set; }

    public List<Image> Images { get; set; } = [];
}