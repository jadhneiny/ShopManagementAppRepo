namespace ShopManagementApp.Domain.PromoCode
{
    public class CoreEntities
    {
        public class PromoCodeEntity
        {
            public int PromoCodeId { get; set; }
            public string Code { get; set; }
            public decimal Discount { get; set; }
            public DateTime ExpirationDate { get; set; }
            public int TenantId { get; set; }
        }
    }
}