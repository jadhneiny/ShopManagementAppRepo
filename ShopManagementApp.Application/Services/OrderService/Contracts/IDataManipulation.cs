using ShopManagementApp.Domain.Order;

namespace ShopManagementApp.Application.Contracts;

public partial interface IOrderService
{
    Task Delete_Order_details(Params_Delete_Order_details i_Params_Delete_Order_details);
    Task Delete_Order_details_By_ORDERS_ID(Params_Delete_Order_details_By_ORDERS_ID i_Params_Delete_Order_details_By_ORDERS_ID);
    Task Delete_Order_details_By_PRODUCTS_ID(Params_Delete_Order_details_By_PRODUCTS_ID i_Params_Delete_Order_details_By_PRODUCTS_ID);
    Task Delete_Order_details_By_TENANT_ID(Params_Delete_Order_details_By_TENANT_ID i_Params_Delete_Order_details_By_TENANT_ID);
    Task Delete_Order_details_By_TENANTS_ID(Params_Delete_Order_details_By_TENANTS_ID i_Params_Delete_Order_details_By_TENANTS_ID);
    Task Edit_Order_details(Order_details i_Order_details);
    Task Edit_Order_details_List(Params_Edit_Order_details_List i_Params_Edit_Order_details_List);
    Task Delete_Orders(Params_Delete_Orders i_Params_Delete_Orders);
    Task Delete_Orders_By_CUSTOMERS_ID(Params_Delete_Orders_By_CUSTOMERS_ID i_Params_Delete_Orders_By_CUSTOMERS_ID);
    Task Delete_Orders_By_PROMO_CODES_ID(Params_Delete_Orders_By_PROMO_CODES_ID i_Params_Delete_Orders_By_PROMO_CODES_ID);
    Task Delete_Orders_By_TENANT_ID(Params_Delete_Orders_By_TENANT_ID i_Params_Delete_Orders_By_TENANT_ID);
    Task Delete_Orders_By_TENANTS_ID(Params_Delete_Orders_By_TENANTS_ID i_Params_Delete_Orders_By_TENANTS_ID);
    Task Edit_Orders(Orders i_Orders);
    Task Edit_Orders_List(Params_Edit_Orders_List i_Params_Edit_Orders_List);
}
