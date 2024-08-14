using ShopManagementApp.Domain.Product;

namespace ShopManagementApp.Infrastructure.Contracts;

public partial interface IProductRepository
{
    Task<Products> Get_Products_By_PRODUCTS_ID(Params_Get_Products_By_PRODUCTS_ID i_Params_Get_Products_By_PRODUCTS_ID);
    Task<IEnumerable<Products>> Get_Products_By_PRODUCTS_ID_List(Params_Get_Products_By_PRODUCTS_ID_List i_Params_Get_Products_By_PRODUCTS_ID_List);
    Task<Get_Products_By_Properties_Response> Get_Products_By_Properties(Params_Get_Products_By_Properties i_Params_Get_Products_By_Properties);
    Task<IEnumerable<Products>> Get_Products_By_SHOPS_ID(Params_Get_Products_By_SHOPS_ID i_Params_Get_Products_By_SHOPS_ID);
    Task<IEnumerable<Products>> Get_Products_By_SHOPS_ID_List(Params_Get_Products_By_SHOPS_ID_List i_Params_Get_Products_By_SHOPS_ID_List);
    Task<IEnumerable<Products>> Get_Products_By_TENANT_ID(Params_Get_Products_By_TENANT_ID i_Params_Get_Products_By_TENANT_ID);
    Task<IEnumerable<Products>> Get_Products_By_TENANTS_ID(Params_Get_Products_By_TENANTS_ID i_Params_Get_Products_By_TENANTS_ID);
    Task<IEnumerable<Products>> Get_Products_By_TENANTS_ID_List(Params_Get_Products_By_TENANTS_ID_List i_Params_Get_Products_By_TENANTS_ID_List);
    Task<Get_Shops_By_Properties_Response> Get_Shops_By_Properties(Params_Get_Shops_By_Properties i_Params_Get_Shops_By_Properties);
    Task<Shops> Get_Shops_By_SHOPS_ID(Params_Get_Shops_By_SHOPS_ID i_Params_Get_Shops_By_SHOPS_ID);
    Task<IEnumerable<Shops>> Get_Shops_By_SHOPS_ID_List(Params_Get_Shops_By_SHOPS_ID_List i_Params_Get_Shops_By_SHOPS_ID_List);
    Task<IEnumerable<Shops>> Get_Shops_By_TENANT_ID(Params_Get_Shops_By_TENANT_ID i_Params_Get_Shops_By_TENANT_ID);
    Task<IEnumerable<Shops>> Get_Shops_By_TENANTS_ID(Params_Get_Shops_By_TENANTS_ID i_Params_Get_Shops_By_TENANTS_ID);
    Task<IEnumerable<Shops>> Get_Shops_By_TENANTS_ID_List(Params_Get_Shops_By_TENANTS_ID_List i_Params_Get_Shops_By_TENANTS_ID_List);
}
