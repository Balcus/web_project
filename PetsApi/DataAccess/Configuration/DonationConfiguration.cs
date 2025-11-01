using Api.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess.Configuration
{
    public class DonationConfiguration : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.ToTable("Donations");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.UserId)
                .IsRequired();

            builder.Property(d => d.AmountDonated)
                .IsRequired()
                .HasPrecision(18, 2);

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(d => d.UserId);
        }
    }
}