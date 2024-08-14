namespace ShopManagementApp.Domain.Product;

public partial class Params_Get_Products_By_PRODUCTS_ID
{
    public int PRODUCTS_ID { get; set; }
}
public partial class Params_Get_Products_By_PRODUCTS_ID_List
{
    public IEnumerable<int> PRODUCTS_ID_LIST { get; set; }
}
public partial class Params_Get_Products_By_Properties
{
    public int? PRODUCTS_ID { get; set; }
    public IEnumerable<int?> PRODUCTS_ID_LIST { get; set; }
    public int? SHOPS_ID { get; set; }
    public IEnumerable<int?> SHOPS_ID_LIST { get; set; }
    public string PRODUCT_NAME { get; set; }
    public decimal? PRICE { get; set; }
    public string IMAGE { get; set; }
    public string DESCRIPTION { get; set; }
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
public partial class Params_Get_Products_By_SHOPS_ID
{
    public int? SHOPS_ID { get; set; }
}
public partial class Params_Get_Products_By_SHOPS_ID_List
{
    public IEnumerable<int?> SHOPS_ID_LIST { get; set; }
}
public partial class Params_Get_Products_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Products_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Products_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_Shops_By_Properties
{
    public int? SHOPS_ID { get; set; }
    public IEnumerable<int?> SHOPS_ID_LIST { get; set; }
    public string NAME { get; set; }
    public string CURRENCY { get; set; }
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
public partial class Params_Get_Shops_By_SHOPS_ID
{
    public int SHOPS_ID { get; set; }
}
public partial class Params_Get_Shops_By_SHOPS_ID_List
{
    public IEnumerable<int> SHOPS_ID_LIST { get; set; }
}
public partial class Params_Get_Shops_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Shops_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Shops_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Delete_Products
{
    public int PRODUCTS_ID { get; set; }
}
public partial class Params_Delete_Products_By_SHOPS_ID
{
    public int? SHOPS_ID { get; set; }
}
public partial class Params_Delete_Products_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Products_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Products_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Products> List_To_Edit { get; set; }
    public IEnumerable<Products> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Shops
{
    public int SHOPS_ID { get; set; }
}
public partial class Params_Delete_Shops_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Shops_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Shops_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Shops> List_To_Edit { get; set; }
    public IEnumerable<Shops> List_Failed_Edit { get; set; }
}
