

namespace EatingApp.Entities
{
    public class Product: IEntity<int>
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public decimal Price { get; set; }
    }
}