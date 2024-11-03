using InovaX.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InovaX.Database.Mappings
{
    public class RealProductsMapping : IEntityTypeConfiguration<RealProducts>
    {
        public void Configure(EntityTypeBuilder<RealProducts> builder)
        {
            builder.ToTable("InovaX_Tb_RealProducts");

            builder.HasNoKey();

            builder.Property(rp => rp.Name)
                .IsRequired();

            builder.Property(rp => rp.Category)
                .IsRequired();
        }
    }
}
