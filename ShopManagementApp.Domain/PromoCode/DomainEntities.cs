using ShopManagementApp.Domain.Attributes;
using ShopManagementApp.Domain.Common;

namespace ShopManagementApp.Domain.PromoCode;

public partial class Promo_codes
{
    public int PROMO_CODES_ID { get; set; }
    public string CODE { get; set; }
    public decimal DISCOUNT { get; set; }
    public DateTime EXPIRATION_DATE { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Promo_codes_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Promo_codes> List_Promo_codes { get; set; }
}
