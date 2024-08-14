namespace ShopManagementApp.Domain.Order;

public partial class Params_Get_Order_details_By_ORDER_DETAILS_ID
{
    public int ORDER_DETAILS_ID { get; set; }
}
public partial class Params_Get_Order_details_By_ORDER_DETAILS_ID_List
{
    public IEnumerable<int> ORDER_DETAILS_ID_LIST { get; set; }
}
public partial class Params_Get_Order_details_By_ORDERS_ID
{
    public int? ORDERS_ID { get; set; }
}
public partial class Params_Get_Order_details_By_ORDERS_ID_List
{
    public IEnumerable<int?> ORDERS_ID_LIST { get; set; }
}
public partial class Params_Get_Order_details_By_PRODUCTS_ID
{
    public int? PRODUCTS_ID { get; set; }
}
public partial class Params_Get_Order_details_By_PRODUCTS_ID_List
{
    public IEnumerable<int?> PRODUCTS_ID_LIST { get; set; }
}
public partial class Params_Get_Order_details_By_Properties
{
    public int? ORDER_DETAILS_ID { get; set; }
    public IEnumerable<int?> ORDER_DETAILS_ID_LIST { get; set; }
    public int? ORDERS_ID { get; set; }
    public IEnumerable<int?> ORDERS_ID_LIST { get; set; }
    public int? PRODUCTS_ID { get; set; }
    public IEnumerable<int?> PRODUCTS_ID_LIST { get; set; }
    public int? QUANTITY { get; set; }
    public decimal? PRICE { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public string DESCRIPTION { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Order_details_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Order_details_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Order_details_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_Orders_By_CUSTOMERS_ID
{
    public int? CUSTOMERS_ID { get; set; }
}
public partial class Params_Get_Orders_By_CUSTOMERS_ID_List
{
    public IEnumerable<int?> CUSTOMERS_ID_LIST { get; set; }
}
public partial class Params_Get_Orders_By_ORDERS_ID
{
    public int ORDERS_ID { get; set; }
}
public partial class Params_Get_Orders_By_ORDERS_ID_List
{
    public IEnumerable<int> ORDERS_ID_LIST { get; set; }
}
public partial class Params_Get_Orders_By_PROMO_CODES_ID
{
    public int? PROMO_CODES_ID { get; set; }
}
public partial class Params_Get_Orders_By_PROMO_CODES_ID_List
{
    public IEnumerable<int?> PROMO_CODES_ID_LIST { get; set; }
}
public partial class Params_Get_Orders_By_Properties
{
    public int? ORDERS_ID { get; set; }
    public IEnumerable<int?> ORDERS_ID_LIST { get; set; }
    public int? CUSTOMERS_ID { get; set; }
    public IEnumerable<int?> CUSTOMERS_ID_LIST { get; set; }
    public DateTime? ORDER_DATE { get; set; }
    public DateTime? ORDER_DATE_START { get; set; }
    public DateTime? ORDER_DATE_END { get; set; }
    public bool? ORDER_DATE_INCLUSIVE { get; set; }
    public string STATUS { get; set; }
    public int? PROMO_CODES_ID { get; set; }
    public IEnumerable<int?> PROMO_CODES_ID_LIST { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Orders_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Orders_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Orders_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Delete_Order_details
{
    public int ORDER_DETAILS_ID { get; set; }
}
public partial class Params_Delete_Order_details_By_ORDERS_ID
{
    public int? ORDERS_ID { get; set; }
}
public partial class Params_Delete_Order_details_By_PRODUCTS_ID
{
    public int? PRODUCTS_ID { get; set; }
}
public partial class Params_Delete_Order_details_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Order_details_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Order_details_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Order_details> List_To_Edit { get; set; }
    public IEnumerable<Order_details> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Orders
{
    public int ORDERS_ID { get; set; }
}
public partial class Params_Delete_Orders_By_CUSTOMERS_ID
{
    public int? CUSTOMERS_ID { get; set; }
}
public partial class Params_Delete_Orders_By_PROMO_CODES_ID
{
    public int? PROMO_CODES_ID { get; set; }
}
public partial class Params_Delete_Orders_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Orders_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Orders_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Orders> List_To_Edit { get; set; }
    public IEnumerable<Orders> List_Failed_Edit { get; set; }
}
