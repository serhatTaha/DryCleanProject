using DryClean.Entities.Conrete;
using DryClean.Entities.Entityconfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DryClean.Entities.Entityconfig.Concrete
{
    public class RoleConfig : BaseConfig<Role, int>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).HasMaxLength(50);

        }
    }
}
