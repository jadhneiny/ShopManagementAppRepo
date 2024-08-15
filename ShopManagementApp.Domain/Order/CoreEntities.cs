namespace ShopManagementApp.Domain.Order
{
    public class CoreEntities
    {
        public class OrderEntity
        {
            public int OrderId { get; set; }
            public int CustomerId { get; set; }
            public DateTime OrderDate { get; set; }
            public string Status { get; set; }
            public int TenantId { get; set; }
        }

        public class OrderDetailEntity
        {
            public int OrderDetailId { get; set; }
            public int OrderId { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public int TenantId { get; set; }
        }
    }
}