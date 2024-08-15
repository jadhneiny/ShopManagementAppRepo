namespace ShopManagementApp.Domain.Product
{
    public class CoreEntities
    {
        public class ProductEntity
        {
            public int ProductId { get; set; }
            public int ShopId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public string Image { get; set; }
            public string Description { get; set; }
            public int TenantId { get; set; }
        }

        public class ShopEntity
        {
            public int ShopId { get; set; }
            public string Name { get; set; }
            public string Currency { get; set; }
            public int TenantId { get; set; }
        }
    }
}