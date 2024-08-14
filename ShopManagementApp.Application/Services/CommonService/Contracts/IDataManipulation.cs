using ShopManagementApp.Domain.Common;

namespace ShopManagementApp.Application.Contracts;

public partial interface ICommonService
{
    Task Delete_Tenants(Params_Delete_Tenants i_Params_Delete_Tenants);
    Task Delete_Tenants_By_TENANT_ID(Params_Delete_Tenants_By_TENANT_ID i_Params_Delete_Tenants_By_TENANT_ID);
    Task Edit_Tenants(Tenants i_Tenants);
    Task Edit_Tenants_List(Params_Edit_Tenants_List i_Params_Edit_Tenants_List);
}
