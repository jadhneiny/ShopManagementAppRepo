namespace ShopManagementApp.Domain.Order
{
    public class CoreParams
    {
        public class Params_Get_Order_By_Id
        {
            public int OrderId { get; set; }
        }

        public class Params_Get_Order_Details_By_Order_Id
        {
            public int OrderId { get; set; }
        }
    }
}