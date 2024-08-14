using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Order;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class OrderRepository
{
    public async Task<Order_details> Get_Order_details_By_ORDER_DETAILS_ID(Params_Get_Order_details_By_ORDER_DETAILS_ID i_Params_Get_Order_details_By_ORDER_DETAILS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDER_DETAILS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            var oOrder_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.QuerySingle, "UP_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDERS_ID);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_ORDERS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDERS_ID_List);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_ORDERS_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_PRODUCTS_ID);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_PRODUCTS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_PRODUCTS_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_PROPERTIES", _params).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Order_details_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_Properties);
            }

            return new()
            {
                List_Order_details = oList_Order_details,
                TOTAL_COUNT = oTotalCount
            };
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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANT_ID);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_TENANT_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANTS_ID);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_TENANTS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANTS_ID_List);
            var oList_Order_details = await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Query, "UP_GET_ORDER_DETAILS_BY_TENANTS_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_CUSTOMERS_ID);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_CUSTOMERS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_CUSTOMERS_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_ORDERS_ID);
            var oOrders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.QuerySingle, "UP_GET_ORDERS_BY_ORDERS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_ORDERS_ID_List);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_ORDERS_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_PROMO_CODES_ID);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_PROMO_CODES_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_PROMO_CODES_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_PROPERTIES", _params).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Orders_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_Properties);
            }

            return new()
            {
                List_Orders = oList_Orders,
                TOTAL_COUNT = oTotalCount
            };
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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANT_ID);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_TENANT_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANTS_ID);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_TENANTS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANTS_ID_List);
            var oList_Orders = await _databaseContext.Execute<Orders>(Enum_Operation_Type.Query, "UP_GET_ORDERS_BY_TENANTS_ID_LIST", _params).ConfigureAwait(false);

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
