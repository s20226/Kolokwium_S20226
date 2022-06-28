using Kolokwium_S20226.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_S20226.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                 .HasKey(e => e.TeamID);
            builder
                .Property(e => e.TeamName).HasMaxLength(50)
                .IsRequired();
            builder
                .Property(e => e.TeamDescription).HasMaxLength(500)
                .IsRequired(false);

            builder
                .HasOne(e => e.Organization)
                .WithMany(e => e.Teams)
                .HasForeignKey(e => e.OrganizationID);

            builder.HasData(
                new Team
                {
                    TeamID=1,OrganizationID=1,TeamName="Pogromcy", TeamDescription="Description"
                }, new Team
                {
                    TeamID = 2,
                    OrganizationID = 2,
                    TeamName = "Best",
                    TeamDescription = "Description"
                }
                );
        }
    }
}
