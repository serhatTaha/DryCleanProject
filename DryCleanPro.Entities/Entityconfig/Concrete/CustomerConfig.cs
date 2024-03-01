using DryClean.Entities.Conrete;
using DryClean.Entities.Entityconfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DryClean.Entities.Entityconfig.Concrete
{
    public class CustomerConfig : BaseConfig<Customer, int>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Surname).HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Address).HasMaxLength(100);

        }
    }
}
