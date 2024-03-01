using DryClean.Entities.Abstract;

namespace DryClean.Entities.Conrete
{
    public class Customer : BaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public ICollection<Role>? Rollers { get; set; }
    }
}
