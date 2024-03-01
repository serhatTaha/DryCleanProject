using DryClean.Entities.Abstract;

namespace DryClean.Entities.Conrete
{
    public class Categorie : BaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
