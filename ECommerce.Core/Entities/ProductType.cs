namespace ECommerce.Core.Entities
{
    public class ProductType : BaseEntity
    {
        public string Name { get; set; }

        // Navigation Property
        
        


        

        public int ProductId { get; set; } // review again
        public ICollection<Product> Products { get; set; }
    }
}
