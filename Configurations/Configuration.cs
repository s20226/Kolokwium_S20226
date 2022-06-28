using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_S20226.Configurations
{
    public class Configuration : IEntityTypeConfiguration<Tabela>
    {
        public void Configure(EntityTypeBuilder<Tabela> builder)
        {
            builder
                 .HasKey(e => e.Id);
            builder
                .Property(e => e.Cos);

            builder
                .HasOne(e => cos)
                .WithMany(e => Tabela)
                .HasForeignKey(e => e.Idczegos)

            builder.HasData(
                new Cos { }
                );
        }
    }
}
