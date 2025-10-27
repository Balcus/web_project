using Api.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess.Configuration
{
    public class ShelterConfiguration : IEntityTypeConfiguration<Shelter>
    {
        public void Configure(EntityTypeBuilder<Shelter> builder)
        {
            builder.ToTable("Shelters");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(s => s.Description)
                .HasMaxLength(2000);

            builder.Property(s => s.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(s => s.Email)
                .HasMaxLength(100);

            builder.Property(s => s.AddressLine)
                .HasMaxLength(200);

            builder.Property(s => s.City)
                .HasMaxLength(100);

            builder.Property(s => s.State)
                .HasMaxLength(100);

            builder.Property(s => s.PostalCode)
                .HasMaxLength(20);

            builder.Property(s => s.Country)
                .HasMaxLength(100);

            builder.Property(s => s.Latitude)
                .IsRequired()
                .HasPrecision(9, 6);

            builder.Property(s => s.Longitude)
                .IsRequired()
                .HasPrecision(9, 6);

            builder.HasMany(s => s.Images)
                .WithOne()
                .HasForeignKey("ShelterId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(s => s.City);
        }
    }
}