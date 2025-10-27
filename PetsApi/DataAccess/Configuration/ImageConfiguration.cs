using Api.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess.Configuration
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.FileName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(i => i.ContentType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(i => i.FileSize)
                .IsRequired();

            builder.Property(i => i.Data)
                .IsRequired()
                .HasColumnType("bytea");

            builder.Property(i => i.Category)
                .HasMaxLength(50);

            builder.Property(i => i.UploadUserId)
                .IsRequired();

            builder.Property(i => i.UploadedAt)
                .IsRequired()
                .HasDefaultValueSql("NOW()");

            builder.HasOne(i => i.UploadUser)
                .WithMany()
                .HasForeignKey(i => i.UploadUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}