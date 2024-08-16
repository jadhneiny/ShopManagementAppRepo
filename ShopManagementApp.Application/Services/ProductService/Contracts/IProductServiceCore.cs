namespace ShopManagementApp.Application.Contracts
{
    public partial interface IProductService
    {
        ProductEntity Get_Product_By_Id(Params_Get_Product_By_Id i_Params_Get_Product_By_Id);
        List<ProductEntity> Get_All_Products();
        ShopEntity Get_Shop_By_Id(Params_Get_Shop_By_Id i_Params_Get_Shop_By_Id);
        List<ShopEntity> Get_All_Shops();
    }
}