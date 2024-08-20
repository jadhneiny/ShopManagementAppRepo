namespace ShopManagementApp.Application.Services;
{
    public partial class AddressService
    {
        private void PostConstruct()
        {
            // Custom logic that runs after construction can be added here
        }

        public AddressEntity Get_Address_By_Id(Params_Get_Address_By_Id i_Params_Get_Address_By_Id)
        {
            return _context.Addresses.Find(i_Params_Get_Address_By_Id.AddressId);
        }

        public List<AddressEntity> Get_All_Addresses_By_Customer_Id(Params_Get_All_Addresses_By_Customer_Id i_Params_Get_All_Addresses_By_Customer_Id)
        {
            return _context.Addresses.Where(a => a.CustomerId == i_Params_Get_All_Addresses_By_Customer_Id.CustomerId).ToList();
        }
    }

    public class Params_Get_Address_By_Id
    {
        public int AddressId { get; set; }
    }

    public class Params_Get_All_Addresses_By_Customer_Id
    {
        public int CustomerId { get; set; }
    }
}