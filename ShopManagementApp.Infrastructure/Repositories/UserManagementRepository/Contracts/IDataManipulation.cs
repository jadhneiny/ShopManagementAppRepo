using ShopManagementApp.Domain.UserManagement;

namespace ShopManagementApp.Infrastructure.Contracts;

public partial interface IUserManagementRepository
{
    Task Delete_Admins(Params_Delete_Admins i_Params_Delete_Admins);
    Task Delete_Admins_By_TENANT_ID(Params_Delete_Admins_By_TENANT_ID i_Params_Delete_Admins_By_TENANT_ID);
    Task Delete_Admins_By_TENANTS_ID(Params_Delete_Admins_By_TENANTS_ID i_Params_Delete_Admins_By_TENANTS_ID);
    Task Edit_Admins(Admins i_Admins);
    Task Delete_Customers(Params_Delete_Customers i_Params_Delete_Customers);
    Task Delete_Customers_By_TENANT_ID(Params_Delete_Customers_By_TENANT_ID i_Params_Delete_Customers_By_TENANT_ID);
    Task Delete_Customers_By_TENANTS_ID(Params_Delete_Customers_By_TENANTS_ID i_Params_Delete_Customers_By_TENANTS_ID);
    Task Edit_Customers(Customers i_Customers);
}
