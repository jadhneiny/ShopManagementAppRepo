namespace ShopManagementApp.Application.Contracts
{
    public partial interface IAddressService
    {
        AddressEntity Get_Address_By_Id(Params_Get_Address_By_Id i_Params_Get_Address_By_Id);
        List<AddressEntity> Get_All_Addresses_By_Customer_Id(Params_Get_All_Addresses_By_Customer_Id i_Params_Get_All_Addresses_By_Customer_Id);
    }
}