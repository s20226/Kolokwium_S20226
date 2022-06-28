using Kolokwium_S20226.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_S20226.Configurations
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder
                 .HasKey(e => new { e.MemberID, e.TeamID });

            builder
                .HasOne(e => e.Member)
                .WithMany(e => e.Memberships)
                .HasForeignKey(e => e.MemberID);

            builder
                .HasOne(e => e.Team)
                .WithMany(e => e.Memberships)
                .HasForeignKey(e => e.TeamID);

            builder.HasData(
                new Membership
                {

                }
        );
        }
    }
}
