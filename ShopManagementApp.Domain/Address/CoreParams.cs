namespace ShopManagementApp.Domain.Address
{
    public class CoreParams
    {
        public class Params_Get_Address_By_Id
        {
            public int AddressId { get; set; }
        }

        public class Params_Get_All_Addresses_By_Customer_Id
        {
            public int CustomerId { get; set; }
        }
    }
}