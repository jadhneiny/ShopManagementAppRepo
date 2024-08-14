namespace ShopManagementApp.Application.Services
{
    public partial class OrderService
    {
        private void PostConstruct()
        {
            // Custom logic that runs after construction can be added here
        }

        public OrderEntity Get_Order_By_Id(Params_Get_Order_By_Id i_Params_Get_Order_By_Id)
        {
            return _context.Orders.Find(i_Params_Get_Order_By_Id.OrderId);
        }

        public List<OrderEntity> Get_All_Orders()
        {
            return _context.Orders.ToList();
        }

        public List<OrderDetailEntity> Get_Order_Details_By_Order_Id(Params_Get_Order_Details_By_Order_Id i_Params_Get_Order_Details_By_Order_Id)
        {
            return _context.OrderDetails.Where(od => od.OrderId == i_Params_Get_Order_Details_By_Order_Id.OrderId).ToList();
        }
    }

    public class Params_Get_Order_By_Id
    {
        public int OrderId { get; set; }
    }

    public class Params_Get_Order_Details_By_Order_Id
    {
        public int OrderId { get; set; }
    }
}