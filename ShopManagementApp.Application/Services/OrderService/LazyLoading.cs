using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Order;

namespace ShopManagementApp.Application.Services;

public partial class OrderService
{
    public async Task<Order_details> Get_Order_details_By_ORDER_DETAILS_ID(Params_Get_Order_details_By_ORDER_DETAILS_ID i_Params_Get_Order_details_By_ORDER_DETAILS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDER_DETAILS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);

            Order_details oOrder_details = null;

            oOrder_details = await _orderRepository.Get_Order_details_By_ORDER_DETAILS_ID(i_Params_Get_Order_details_By_ORDER_DETAILS_ID).ConfigureAwait(false);

            if (oOrder_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDER_DETAILS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDER_DETAILS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            }

            return oOrder_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDER_DETAILS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDER_DETAILS_ID_List(Params_Get_Order_details_By_ORDER_DETAILS_ID_List i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDER_DETAILS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _orderRepository.Get_Order_details_By_ORDER_DETAILS_ID_List(i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDER_DETAILS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDER_DETAILS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDER_DETAILS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID(Params_Get_Order_details_By_ORDERS_ID i_Params_Get_Order_details_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID);

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _orderRepository.Get_Order_details_By_ORDERS_ID(i_Params_Get_Order_details_By_ORDERS_ID).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDERS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDERS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDERS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID_List(Params_Get_Order_details_By_ORDERS_ID_List i_Params_Get_Order_details_By_ORDERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID_List);

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _orderRepository.Get_Order_details_By_ORDERS_ID_List(i_Params_Get_Order_details_By_ORDERS_ID_List).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID(Params_Get_Order_details_By_PRODUCTS_ID i_Params_Get_Order_details_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID);

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _orderRepository.Get_Order_details_By_PRODUCTS_ID(i_Params_Get_Order_details_By_PRODUCTS_ID).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_PRODUCTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_PRODUCTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID_List(Params_Get_Order_details_By_PRODUCTS_ID_List i_Params_Get_Order_details_By_PRODUCTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_PRODUCTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _orderRepository.Get_Order_details_By_PRODUCTS_ID_List(i_Params_Get_Order_details_By_PRODUCTS_ID_List).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_PRODUCTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_PRODUCTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_PRODUCTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            throw;
        }
    }

    public async Task<Get_Order_details_By_Properties_Response> Get_Order_details_By_Properties(Params_Get_Order_details_By_Properties i_Params_Get_Order_details_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_Properties);

            Get_Order_details_By_Properties_Response oGet_Order_details_By_Properties_Response = null;

            if (i_Params_Get_Order_details_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Order_details_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Order_details_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Order_details_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Order_details_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Order_details_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Order_details_By_Properties.IS_EAGER_LOAD = false;

            oGet_Order_details_By_Properties_Response = await _orderRepository.Get_Order_details_By_Properties(i_Params_Get_Order_details_By_Properties).ConfigureAwait(false);

            if (oGet_Order_details_By_Properties_Response != null && oGet_Order_details_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Order_details_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Order_details_By_Properties, oGet_Order_details_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_Properties);
            }

            return oGet_Order_details_By_Properties_Response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANT_ID(Params_Get_Order_details_By_TENANT_ID i_Params_Get_Order_details_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANT_ID);

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _orderRepository.Get_Order_details_By_TENANT_ID(i_Params_Get_Order_details_By_TENANT_ID).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANT_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID(Params_Get_Order_details_By_TENANTS_ID i_Params_Get_Order_details_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID);

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _orderRepository.Get_Order_details_By_TENANTS_ID(i_Params_Get_Order_details_By_TENANTS_ID).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANTS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID_List(Params_Get_Order_details_By_TENANTS_ID_List i_Params_Get_Order_details_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID_List);

            IEnumerable<Order_details> oList_Order_details = null;

            oList_Order_details = await _orderRepository.Get_Order_details_By_TENANTS_ID_List(i_Params_Get_Order_details_By_TENANTS_ID_List).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID(Params_Get_Orders_By_CUSTOMERS_ID i_Params_Get_Orders_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID);

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _orderRepository.Get_Orders_By_CUSTOMERS_ID(i_Params_Get_Orders_By_CUSTOMERS_ID).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID_List(Params_Get_Orders_By_CUSTOMERS_ID_List i_Params_Get_Orders_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_CUSTOMERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _orderRepository.Get_Orders_By_CUSTOMERS_ID_List(i_Params_Get_Orders_By_CUSTOMERS_ID_List).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_CUSTOMERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_CUSTOMERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_CUSTOMERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Orders> Get_Orders_By_ORDERS_ID(Params_Get_Orders_By_ORDERS_ID i_Params_Get_Orders_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID);

            Orders oOrders = null;

            oOrders = await _orderRepository.Get_Orders_By_ORDERS_ID(i_Params_Get_Orders_By_ORDERS_ID).ConfigureAwait(false);

            if (oOrders != null)
            {
                _logger.LogInformation("Get_Orders_By_ORDERS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_ORDERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_ORDERS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_ORDERS_ID);
            }

            return oOrders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_ORDERS_ID_List(Params_Get_Orders_By_ORDERS_ID_List i_Params_Get_Orders_By_ORDERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_ORDERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID_List);

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _orderRepository.Get_Orders_By_ORDERS_ID_List(i_Params_Get_Orders_By_ORDERS_ID_List).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_ORDERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_ORDERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_ORDERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_ORDERS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_ORDERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID(Params_Get_Orders_By_PROMO_CODES_ID i_Params_Get_Orders_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_PROMO_CODES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID);

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _orderRepository.Get_Orders_By_PROMO_CODES_ID(i_Params_Get_Orders_By_PROMO_CODES_ID).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_PROMO_CODES_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_PROMO_CODES_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_PROMO_CODES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID_List(Params_Get_Orders_By_PROMO_CODES_ID_List i_Params_Get_Orders_By_PROMO_CODES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_PROMO_CODES_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _orderRepository.Get_Orders_By_PROMO_CODES_ID_List(i_Params_Get_Orders_By_PROMO_CODES_ID_List).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_PROMO_CODES_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_PROMO_CODES_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_PROMO_CODES_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            throw;
        }
    }

    public async Task<Get_Orders_By_Properties_Response> Get_Orders_By_Properties(Params_Get_Orders_By_Properties i_Params_Get_Orders_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_Properties);

            Get_Orders_By_Properties_Response oGet_Orders_By_Properties_Response = null;

            if (i_Params_Get_Orders_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Orders_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Orders_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Orders_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Orders_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Orders_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Orders_By_Properties.IS_EAGER_LOAD = false;

            oGet_Orders_By_Properties_Response = await _orderRepository.Get_Orders_By_Properties(i_Params_Get_Orders_By_Properties).ConfigureAwait(false);

            if (oGet_Orders_By_Properties_Response != null && oGet_Orders_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Orders_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Orders_By_Properties, oGet_Orders_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_Properties);
            }

            return oGet_Orders_By_Properties_Response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANT_ID(Params_Get_Orders_By_TENANT_ID i_Params_Get_Orders_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANT_ID);

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _orderRepository.Get_Orders_By_TENANT_ID(i_Params_Get_Orders_By_TENANT_ID).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANT_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID(Params_Get_Orders_By_TENANTS_ID i_Params_Get_Orders_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID);

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _orderRepository.Get_Orders_By_TENANTS_ID(i_Params_Get_Orders_By_TENANTS_ID).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANTS_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID_List(Params_Get_Orders_By_TENANTS_ID_List i_Params_Get_Orders_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID_List);

            IEnumerable<Orders> oList_Orders = null;

            oList_Orders = await _orderRepository.Get_Orders_By_TENANTS_ID_List(i_Params_Get_Orders_By_TENANTS_ID_List).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANTS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID_List);
            throw;
        }
    }
}
