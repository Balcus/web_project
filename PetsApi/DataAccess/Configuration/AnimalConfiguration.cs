using Api.DataAccess.Enums;
using Api.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess.Configuration
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animals");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Species)
                .IsRequired();

            builder.Property(a => a.Breed)
                .HasMaxLength(100);

            builder.Property(a => a.Age)
                .IsRequired();

            builder.Property(a => a.Gender);

            builder.Property(a => a.IsVaccinated)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(a => a.IsNeutered)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(a => a.AdditionalNotes)
                .HasMaxLength(1000);

            builder.Property(a => a.AddedByUserId)
                .IsRequired();

            builder.Property(a => a.AdoptionStatus)
                .IsRequired()
                .HasDefaultValue(AnimalStatus.Available);

            builder.Property(a => a.DateArrived)
                .IsRequired()
                .HasDefaultValueSql("NOW()");

            builder.Property(a => a.ShelterId);

            builder.HasOne(a => a.AddedByUser)
                .WithMany()
                .HasForeignKey(a => a.AddedByUserId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(a => a.FromShelter)
                .WithMany()
                .HasForeignKey(a => a.ShelterId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(a => a.Images)
                .WithOne()
                .HasForeignKey("AnimalId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(a => a.Species);
            builder.HasIndex(a => a.AdoptionStatus);
            builder.HasIndex(a => a.ShelterId);
        }
    }
}