using ShopManagementApp.Domain.Attributes;
using ShopManagementApp.Domain.Common;

namespace ShopManagementApp.Domain.Product;

public partial class Products
{
    public int PRODUCTS_ID { get; set; }
    public int? SHOPS_ID { get; set; }
    public string PRODUCT_NAME { get; set; }
    public decimal PRICE { get; set; }
    public string IMAGE { get; set; }
    public string DESCRIPTION { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Shops Shops { get; set; }
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Products_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Products> List_Products { get; set; }
}
public partial class Shops
{
    public int SHOPS_ID { get; set; }
    public string NAME { get; set; }
    public string CURRENCY { get; set; }
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
public partial class Get_Shops_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Shops> List_Shops { get; set; }
}
