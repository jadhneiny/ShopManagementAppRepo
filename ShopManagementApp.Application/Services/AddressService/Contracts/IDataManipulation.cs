using ShopManagementApp.Domain.Address;

namespace ShopManagementApp.Application.Contracts;

public partial interface IAddressService
{
    Task Delete_Addresses(Params_Delete_Addresses i_Params_Delete_Addresses);
    Task Delete_Addresses_By_CUSTOMERS_ID(Params_Delete_Addresses_By_CUSTOMERS_ID i_Params_Delete_Addresses_By_CUSTOMERS_ID);
    Task Delete_Addresses_By_TENANT_ID(Params_Delete_Addresses_By_TENANT_ID i_Params_Delete_Addresses_By_TENANT_ID);
    Task Edit_Addresses(Addresses i_Addresses);
    Task Edit_Addresses_List(Params_Edit_Addresses_List i_Params_Edit_Addresses_List);
}
