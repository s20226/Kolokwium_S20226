using Kolokwium_S20226.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_S20226.Configurations
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder
                 .HasKey(e => e.MemberID);
            builder
                .Property(e => e.MemberName).HasMaxLength(20)
                .IsRequired();
            builder
                .Property(e => e.MemberSurname).HasMaxLength(50)
                .IsRequired();

            builder
                .Property(e => e.MemberNickName).HasMaxLength(20).IsRequired(false);

            builder
                .HasOne(e => e.Organization)
                .WithMany(e => e.Members)
                .HasForeignKey(e => e.OrganizationID);

            builder.HasData(
                new Member
                {

                }
                );
        }
    }
}
