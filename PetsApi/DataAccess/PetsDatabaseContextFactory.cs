using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.DataAccess
{
    public class PetsDatabaseContextFactory : IDesignTimeDbContextFactory<PetsDatabaseContext>
    {
        public PetsDatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PetsDatabaseContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=33861;Username=postgres;Password=t(A_HJEjRGV0_.t8wRHWFh;Database=appdb");
            return new PetsDatabaseContext(optionsBuilder.Options);
        }
    }
}