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
                .HasForeignKey(e => e.MemberID).OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(e => e.Team)
                .WithMany(e => e.Memberships)
                .HasForeignKey(e => e.TeamID).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new Membership
                {
                   MemberID=1, TeamID=1, MembershipDate=System.DateTime.Now

                },
                                new Membership
                                {
                                    MemberID = 2,
                                    TeamID = 1,
                                    MembershipDate = System.DateTime.Now

                                },
                                                new Membership
                                                {
                                                    MemberID = 3,
                                                    TeamID = 2,
                                                    MembershipDate = System.DateTime.Now

                                                }
        );
        }
    }
}
