using ShopManagementApp.Domain.Attributes;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Domain.Product;
using ShopManagementApp.Domain.PromoCode;
using ShopManagementApp.Domain.UserManagement;

namespace ShopManagementApp.Domain.Order;

public partial class Order_details
{
    public int ORDER_DETAILS_ID { get; set; }
    public int? ORDERS_ID { get; set; }
    public int? PRODUCTS_ID { get; set; }
    public int? QUANTITY { get; set; }
    public decimal? PRICE { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public string DESCRIPTION { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Orders Orders { get; set; }
    [SQLIgnore]
    public Products Products { get; set; }
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Order_details_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Order_details> List_Order_details { get; set; }
}
public partial class Orders
{
    public int ORDERS_ID { get; set; }
    public int? CUSTOMERS_ID { get; set; }
    public DateTime? ORDER_DATE { get; set; }
    public string STATUS { get; set; }
    public int? PROMO_CODES_ID { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Customers Customers { get; set; }
    [SQLIgnore]
    public Promo_codes Promo_codes { get; set; }
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Orders_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Orders> List_Orders { get; set; }
}
