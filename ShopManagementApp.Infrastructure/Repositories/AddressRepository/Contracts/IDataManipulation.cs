using ShopManagementApp.Domain.Address;

namespace ShopManagementApp.Infrastructure.Contracts;

public partial interface IAddressRepository
{
    Task Delete_Addresses(Params_Delete_Addresses i_Params_Delete_Addresses);
    Task Delete_Addresses_By_CUSTOMERS_ID(Params_Delete_Addresses_By_CUSTOMERS_ID i_Params_Delete_Addresses_By_CUSTOMERS_ID);
    Task Delete_Addresses_By_TENANT_ID(Params_Delete_Addresses_By_TENANT_ID i_Params_Delete_Addresses_By_TENANT_ID);
    Task Edit_Addresses(Addresses i_Addresses);
}
