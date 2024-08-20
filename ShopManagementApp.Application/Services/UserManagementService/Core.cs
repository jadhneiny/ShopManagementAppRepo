namespace ShopManagementApp.Application.Services;
{
    public partial class UserManagementService
    {
        private void PostConstruct()
        {
            // Custom logic that runs after construction can be added here
        }

        public AdminEntity Get_Admin_By_Id(Params_Get_Admin_By_Id i_Params_Get_Admin_By_Id)
        {
            return _context.Admins.Find(i_Params_Get_Admin_By_Id.AdminId);
        }

        public List<AdminEntity> Get_All_Admins()
        {
            return _context.Admins.ToList();
        }

        public CustomerEntity Get_Customer_By_Id(Params_Get_Customer_By_Id i_Params_Get_Customer_By_Id)
        {
            return _context.Customers.Find(i_Params_Get_Customer_By_Id.CustomerId);
        }

        public List<CustomerEntity> Get_All_Customers()
        {
            return _context.Customers.ToList();
        }
    }

    public class Params_Get_Admin_By_Id
    {
        public int AdminId { get; set; }
    }

    public class Params_Get_Customer_By_Id
    {
        public int CustomerId { get; set; }
    }
}