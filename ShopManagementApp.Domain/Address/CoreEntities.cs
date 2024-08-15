namespace ShopManagementApp.Domain.Address
{
    public class CoreEntities
    {
        public class AddressEntity
        {
            public int AddressId { get; set; }
            public int CustomerId { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string Country { get; set; }
            public int TenantId { get; set; }
        }
    }
}