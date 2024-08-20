namespace ShopManagementApp.Application.Services;
{
    public partial class ProductService
    {
        private void PostConstruct()
        {
            // Custom logic that runs after construction can be added here
        }

        public ProductEntity Get_Product_By_Id(Params_Get_Product_By_Id i_Params_Get_Product_By_Id)
        {
            return _context.Products.Find(i_Params_Get_Product_By_Id.ProductId);
        }

        public List<ProductEntity> Get_All_Products()
        {
            return _context.Products.ToList();
        }

        public ShopEntity Get_Shop_By_Id(Params_Get_Shop_By_Id i_Params_Get_Shop_By_Id)
        {
            return _context.Shops.Find(i_Params_Get_Shop_By_Id.ShopId);
        }

        public List<ShopEntity> Get_All_Shops()
        {
            return _context.Shops.ToList();
        }
    }

    public class Params_Get_Product_By_Id
    {
        public int ProductId { get; set; }
    }

    public class Params_Get_Shop_By_Id
    {
        public int ShopId { get; set; }
    }
}