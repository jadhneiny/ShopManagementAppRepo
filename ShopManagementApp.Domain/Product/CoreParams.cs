namespace ShopManagementApp.Domain.Product
{
    public class CoreParams
    {
        public class Params_Get_Product_By_Id
        {
            public int ProductId { get; set; }
        }

        public class Params_Get_Shop_By_Id
        {
            public int ShopId { get; set; }
        }
    }
}