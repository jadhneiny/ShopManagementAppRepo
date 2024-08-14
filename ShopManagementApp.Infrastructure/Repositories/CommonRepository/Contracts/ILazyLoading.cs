using ShopManagementApp.Domain.Common;

namespace ShopManagementApp.Infrastructure.Contracts;

public partial interface ICommonRepository
{
    Task<Get_Tenants_By_Properties_Response> Get_Tenants_By_Properties(Params_Get_Tenants_By_Properties i_Params_Get_Tenants_By_Properties);
    Task<IEnumerable<Tenants>> Get_Tenants_By_TENANT_ID(Params_Get_Tenants_By_TENANT_ID i_Params_Get_Tenants_By_TENANT_ID);
    Task<Tenants> Get_Tenants_By_TENANTS_ID(Params_Get_Tenants_By_TENANTS_ID i_Params_Get_Tenants_By_TENANTS_ID);
    Task<IEnumerable<Tenants>> Get_Tenants_By_TENANTS_ID_List(Params_Get_Tenants_By_TENANTS_ID_List i_Params_Get_Tenants_By_TENANTS_ID_List);
}
