
using DryClean.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DryClean.Entities.Entityconfig.Abstract
{
    public abstract class BaseConfig<T, TId> : IEntityTypeConfiguration<T> where T : BaseEntity<TId>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
