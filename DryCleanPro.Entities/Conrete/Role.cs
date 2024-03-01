using DryClean.Entities.Abstract;

namespace DryClean.Entities.Conrete
{
    public class Role : BaseEntity<int>
    {
        public string Name { get; set; }
        public ICollection<Customer> Customers { get; set; }

        public ICollection<Categorie> Categories { get; set; }
    }
}
