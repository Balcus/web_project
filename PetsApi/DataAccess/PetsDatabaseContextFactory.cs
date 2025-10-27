using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.DataAccess
{
    public class PetsDatabaseContextFactory : IDesignTimeDbContextFactory<PetsDatabaseContext>
    {
        public PetsDatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PetsDatabaseContext>();
            optionsBuilder.UseNpgsql("<connection-string>");
            return new PetsDatabaseContext(optionsBuilder.Options);
        }
    }
}