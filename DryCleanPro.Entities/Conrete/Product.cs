using DryClean.Entities.Abstract;

namespace DryClean.Entities.Conrete
{
    public class Product : BaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

        public ICollection<Categorie> Categories { get; set; }
    }
}
