using DryClean.Entities.Conrete;
using DryClean.Entities.Entityconfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DryClean.Entities.Entityconfig.Concrete
{
    public class KategoriConfig : BaseConfig<Categorie, int>
    {
        public override void Configure(EntityTypeBuilder<Categorie> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50);
        }
    }
}
