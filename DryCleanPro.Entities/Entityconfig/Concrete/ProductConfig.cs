using DryClean.Entities.Conrete;
using DryClean.Entities.Entityconfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DryClean.Entities.Entityconfig.Concrete
{
    public class ProductConfig : BaseConfig<Product, int>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Color).HasMaxLength(50);
            builder.Property(p => p.Material).HasMaxLength(50);
            builder.Property(p => p.Size).HasMaxLength(15);
            builder.Property(p => p.Name).HasMaxLength(70);

        }
    }
}
