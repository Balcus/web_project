using Api.DataAccess.Enums;
using Api.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess;

public class PetsDatabaseContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Animal> Lineup { get; set; }
    public DbSet<Donation> Festival { get; set; }
    public DbSet<Image> Artist { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Post> Booking { get; set; }
    public DbSet<Shelter> Ticket { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum<AnimalStatus>();
        modelBuilder.HasPostgresEnum<Gender>();
        modelBuilder.HasPostgresEnum<Species>();
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PetsDatabaseContext).Assembly);
    }
}