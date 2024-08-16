namespace ShopManagementApp.Application.Contracts
{
    public partial interface IOrderService
    {
        OrderEntity Get_Order_By_Id(Params_Get_Order_By_Id i_Params_Get_Order_By_Id);
        List<OrderEntity> Get_All_Orders();
        List<OrderDetailEntity> Get_Order_Details_By_Order_Id(Params_Get_Order_Details_By_Order_Id i_Params_Get_Order_Details_By_Order_Id);
    }
}