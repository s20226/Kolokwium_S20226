using Kolokwium_S20226.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_S20226.Configurations
{
    public class FileConfiguration : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder
                 .HasKey(e => e.FileID);
            builder
                .Property(e => e.FileName).HasMaxLength(100)
                .IsRequired();
            builder
                .Property(e => e.FileExtension).HasMaxLength(4)
                .IsRequired();
            builder
                .Property(e => e.FileSize).IsRequired();

            builder
                .HasOne(e => e.Team)
                .WithMany(e => e.Files)
                .HasForeignKey(e => e.TeamID);

            builder.HasData(
                new File
                {
                }
                );
        }
    }
}
