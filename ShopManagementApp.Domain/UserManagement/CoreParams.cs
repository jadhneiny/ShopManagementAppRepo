namespace ShopManagementApp.Domain.UserManagement
{
    public class CoreParams
    {
        public class Params_Get_Admin_By_Id
        {
            public int AdminId { get; set; }
        }

        public class Params_Get_Customer_By_Id
        {
            public int CustomerId { get; set; }
        }
    }
}