namespace Api.DataAccess.Models
{
    public class Image : Entity<int>
    {
        public required string FileName { get; set; }
        public required string ContentType { get; set; }
        public long FileSize { get; set; }
        public byte[] Data { get; set; } = [];
        public string? Category { get; set; }
        public int UploadUserId { get; set; }
        public DateTime UploadedAt { get; set; }
        
        public User? UploadUser { get; set; }
    }
}