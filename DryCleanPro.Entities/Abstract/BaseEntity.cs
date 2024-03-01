namespace DryClean.Entities.Abstract
{
    public abstract class BaseEntity<TId>
    {

        public TId Id { get; set; }
    }

}
