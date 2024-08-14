using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Order;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class OrderRepository
{
    public async Task Delete_Order_details(Params_Delete_Order_details i_Params_Delete_Order_details)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Order_details);
            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_DELETE_ORDER_DETAILS", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Order_details operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details);
            throw;
        }
    }

    public async Task Delete_Order_details_By_ORDERS_ID(Params_Delete_Order_details_By_ORDERS_ID i_Params_Delete_Order_details_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Order_details_By_ORDERS_ID);
            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_DELETE_ORDER_DETAILS_BY_ORDERS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Order_details_By_ORDERS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_ORDERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);
            throw;
        }
    }

    public async Task Delete_Order_details_By_PRODUCTS_ID(Params_Delete_Order_details_By_PRODUCTS_ID i_Params_Delete_Order_details_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Order_details_By_PRODUCTS_ID);
            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_DELETE_ORDER_DETAILS_BY_PRODUCTS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Order_details_By_PRODUCTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);
            throw;
        }
    }

    public async Task Delete_Order_details_By_TENANT_ID(Params_Delete_Order_details_By_TENANT_ID i_Params_Delete_Order_details_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Order_details_By_TENANT_ID);
            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_DELETE_ORDER_DETAILS_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Order_details_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Order_details_By_TENANTS_ID(Params_Delete_Order_details_By_TENANTS_ID i_Params_Delete_Order_details_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Order_details_By_TENANTS_ID);
            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_DELETE_ORDER_DETAILS_BY_TENANTS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Order_details_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Order_details(Order_details i_Order_details)
    {
        var operation = i_Order_details.ORDER_DETAILS_ID == -1 ? "Create New Order_details" : "Update Existing Order_details";

        try
        {
            _logger.LogInformation("Initiating Edit_Order_details operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Order_details);
            _params.Add("ORDER_DETAILS_ID", i_Order_details.ORDER_DETAILS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Order_details.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Order_details.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Order_details>(Enum_Operation_Type.Execute, "UP_EDIT_ORDER_DETAILS", _params).ConfigureAwait(false);

            i_Order_details.ORDER_DETAILS_ID = _params.Get<int>("ORDER_DETAILS_ID");
            i_Order_details.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Order_details.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Order_details operation at the repository layer completed successfully: {Operation}. Order_details ID: {ORDER_DETAILS_ID}", operation, i_Order_details.ORDER_DETAILS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Orders(Params_Delete_Orders i_Params_Delete_Orders)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Orders);
            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_DELETE_ORDERS", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Orders operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders);
            throw;
        }
    }

    public async Task Delete_Orders_By_CUSTOMERS_ID(Params_Delete_Orders_By_CUSTOMERS_ID i_Params_Delete_Orders_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Orders_By_CUSTOMERS_ID);
            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_DELETE_ORDERS_BY_CUSTOMERS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Orders_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task Delete_Orders_By_PROMO_CODES_ID(Params_Delete_Orders_By_PROMO_CODES_ID i_Params_Delete_Orders_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_PROMO_CODES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Orders_By_PROMO_CODES_ID);
            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_DELETE_ORDERS_BY_PROMO_CODES_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Orders_By_PROMO_CODES_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_PROMO_CODES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);
            throw;
        }
    }

    public async Task Delete_Orders_By_TENANT_ID(Params_Delete_Orders_By_TENANT_ID i_Params_Delete_Orders_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Orders_By_TENANT_ID);
            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_DELETE_ORDERS_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Orders_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Orders_By_TENANTS_ID(Params_Delete_Orders_By_TENANTS_ID i_Params_Delete_Orders_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Orders_By_TENANTS_ID);
            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_DELETE_ORDERS_BY_TENANTS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Orders_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Orders(Orders i_Orders)
    {
        var operation = i_Orders.ORDERS_ID == -1 ? "Create New Orders" : "Update Existing Orders";

        try
        {
            _logger.LogInformation("Initiating Edit_Orders operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Orders);
            _params.Add("ORDERS_ID", i_Orders.ORDERS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Orders.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Orders.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Orders>(Enum_Operation_Type.Execute, "UP_EDIT_ORDERS", _params).ConfigureAwait(false);

            i_Orders.ORDERS_ID = _params.Get<int>("ORDERS_ID");
            i_Orders.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Orders.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Orders operation at the repository layer completed successfully: {Operation}. Orders ID: {ORDERS_ID}", operation, i_Orders.ORDERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }
}
