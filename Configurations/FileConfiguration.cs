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
                 .HasKey(e => new { e.FileID, e.TeamID });
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
                    FileID = 1,
                    TeamID = 1,
                    FileName = "Filename1",
                    FileExtension = "doc",
                    FileSize = 10
                },
                                new File
                                {
                                    FileID = 2,
                                    TeamID = 2,
                                    FileName = "Filename2",
                                    FileExtension = "doc",
                                    FileSize = 10
                                }

                );
        }
    }
}
