using DryClean.Entities.Abstract;

namespace DryClean.Entities.Conrete
{
    public class Order : BaseEntity<int>
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Piece { get; set; }
        public decimal Price { get; set; }

        public Customer Customer { get; set; }

    }
}
