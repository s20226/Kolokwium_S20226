using Kolokwium_S20226.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_S20226.Configurations
{
    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder
                 .HasKey(e => e.OrganizationID);
            builder
                .Property(e => e.OrganizationName).HasMaxLength(100)
                .IsRequired();
            builder
                .Property(e => e.OrganizationDomain).HasMaxLength(50)
                .IsRequired();


            builder.HasData(
                new Organization
                {
                    OrganizationID=1, OrganizationName="Organization 1", OrganizationDomain="Domain"
                }, new Organization
                {
                    OrganizationID = 2,
                    OrganizationName = "Organization 2",
                    OrganizationDomain = "Domain2"
                }
                );
        }
    }
}
