using Api.DataAccess.Enums;
using Api.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess;

public class PetsDatabaseContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Donation> Donations { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Shelter> Shelters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum<AnimalStatus>();
        modelBuilder.HasPostgresEnum<Gender>();
        modelBuilder.HasPostgresEnum<Species>();
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PetsDatabaseContext).Assembly);
    }
}