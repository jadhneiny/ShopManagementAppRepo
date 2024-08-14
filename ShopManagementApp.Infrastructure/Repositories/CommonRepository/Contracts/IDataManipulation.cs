using ShopManagementApp.Domain.Common;

namespace ShopManagementApp.Infrastructure.Contracts;

public partial interface ICommonRepository
{
    Task Delete_Tenants(Params_Delete_Tenants i_Params_Delete_Tenants);
    Task Delete_Tenants_By_TENANT_ID(Params_Delete_Tenants_By_TENANT_ID i_Params_Delete_Tenants_By_TENANT_ID);
    Task Edit_Tenants(Tenants i_Tenants);
}
