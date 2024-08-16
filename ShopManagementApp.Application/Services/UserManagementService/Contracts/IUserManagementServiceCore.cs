namespace ShopManagementApp.Application.Contracts
{
    public partial interface IUserManagementService
    {
        AdminEntity Get_Admin_By_Id(Params_Get_Admin_By_Id i_Params_Get_Admin_By_Id);
        List<AdminEntity> Get_All_Admins();
        CustomerEntity Get_Customer_By_Id(Params_Get_Customer_By_Id i_Params_Get_Customer_By_Id);
        List<CustomerEntity> Get_All_Customers();
    }
}