using Api.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(u => u.PasswordHash)
                .HasMaxLength(500);

            builder.Property(u => u.AddressLine)
                .HasMaxLength(200);

            builder.Property(u => u.City)
                .HasMaxLength(100);

            builder.Property(u => u.State)
                .HasMaxLength(100);

            builder.Property(u => u.PostalCode)
                .HasMaxLength(20);

            builder.Property(u => u.Country)
                .HasMaxLength(100);

            builder.Property(u => u.StripeCustomerId)
                .HasMaxLength(100);

            builder.Property(u => u.StripePaymentMethodId)
                .HasMaxLength(100);

            builder.Property(u => u.TotalDonated)
                .IsRequired()
                .HasPrecision(18, 2)
                .HasDefaultValue(0m);

            builder.Property(u => u.WantsReceiptEmails)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(u => u.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("NOW()");

            builder.Property(u => u.UpdatedAt);

            builder.HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}