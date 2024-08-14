using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Domain.Order;
using ShopManagementApp.Common.Utilities;
using ShopManagementApp.Common.Exceptions;

namespace ShopManagementApp.Application.Services;

public partial class OrderService
{
    public async Task Delete_Order_details(Params_Delete_Order_details i_Params_Delete_Order_details)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details);

            await _orderRepository.Delete_Order_details(i_Params_Delete_Order_details).ConfigureAwait(false);

            _logger.LogInformation("Delete_Order_details operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Order_details_By_ORDERS_ID(Params_Delete_Order_details_By_ORDERS_ID i_Params_Delete_Order_details_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_ORDERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);

            await _orderRepository.Delete_Order_details_By_ORDERS_ID(i_Params_Delete_Order_details_By_ORDERS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Order_details_By_ORDERS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_ORDERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_ORDERS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Order_details_By_PRODUCTS_ID(Params_Delete_Order_details_By_PRODUCTS_ID i_Params_Delete_Order_details_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_PRODUCTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);

            await _orderRepository.Delete_Order_details_By_PRODUCTS_ID(i_Params_Delete_Order_details_By_PRODUCTS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Order_details_By_PRODUCTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_PRODUCTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_PRODUCTS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Order_details_By_TENANT_ID(Params_Delete_Order_details_By_TENANT_ID i_Params_Delete_Order_details_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);

            await _orderRepository.Delete_Order_details_By_TENANT_ID(i_Params_Delete_Order_details_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Order_details_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Order_details_By_TENANTS_ID(Params_Delete_Order_details_By_TENANTS_ID i_Params_Delete_Order_details_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Order_details_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);

            await _orderRepository.Delete_Order_details_By_TENANTS_ID(i_Params_Delete_Order_details_By_TENANTS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Order_details_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Order_details_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Order_details_By_TENANTS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Order_details(Order_details i_Order_details)
    {
        var operation = i_Order_details.ORDER_DETAILS_ID == -1 ? "Create New Order_details" : "Update Existing Order_details";

        try
        {
            _logger.LogInformation("Initiating Edit_Order_details operation at the service layer: {Operation}.", operation);

            if (i_Order_details.ORDER_DETAILS_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Order_details.ORDER_DETAILS_ID.ToString() }, { "%2", "Edit_Order_details" } });
            }

            i_Order_details.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Order_details.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Order_details.ORDER_DETAILS_ID == -1)
            {
                i_Order_details.IS_DELETED = false;
            }

            await _orderRepository.Edit_Order_details(i_Order_details).ConfigureAwait(false);

            _logger.LogInformation("Edit_Order_details operation at the service layer completed successfully: {Operation}. Order_details ID: {Order_details_id}", operation, i_Order_details.ORDER_DETAILS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Order_details_List(Params_Edit_Order_details_List i_Params_Edit_Order_details_List)
    {
        _logger.LogInformation("Initiating Edit_Order_details_List operation at the repository layer.");

        if (i_Params_Edit_Order_details_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Order_details_List.List_To_Edit.Count());

            (i_Params_Edit_Order_details_List.List_To_Edit, i_Params_Edit_Order_details_List.List_Failed_Edit) = await i_Params_Edit_Order_details_List.List_To_Edit.ProcessBatchOperations(
                Edit_Order_details,
                oOrder_details => oOrder_details
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Order_details_List.List_To_Edit.Count(), i_Params_Edit_Order_details_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Order_details_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Order_details_List.List_To_Delete.Count());

            (i_Params_Edit_Order_details_List.List_To_Delete, i_Params_Edit_Order_details_List.List_Failed_Delete) = await i_Params_Edit_Order_details_List.List_To_Delete.ProcessBatchOperations(
                async oOrder_details_ID => await Delete_Order_details(new() { ORDER_DETAILS_ID = oOrder_details_ID }).ConfigureAwait(false),
                oOrder_details_ID => oOrder_details_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Order_details_List.List_To_Delete.Count(), i_Params_Edit_Order_details_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Order_details_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Orders(Params_Delete_Orders i_Params_Delete_Orders)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders);

            await _orderRepository.Delete_Orders(i_Params_Delete_Orders).ConfigureAwait(false);

            _logger.LogInformation("Delete_Orders operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Orders_By_CUSTOMERS_ID(Params_Delete_Orders_By_CUSTOMERS_ID i_Params_Delete_Orders_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_CUSTOMERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);

            await _orderRepository.Delete_Orders_By_CUSTOMERS_ID(i_Params_Delete_Orders_By_CUSTOMERS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Orders_By_CUSTOMERS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_CUSTOMERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_CUSTOMERS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Orders_By_PROMO_CODES_ID(Params_Delete_Orders_By_PROMO_CODES_ID i_Params_Delete_Orders_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_PROMO_CODES_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);

            await _orderRepository.Delete_Orders_By_PROMO_CODES_ID(i_Params_Delete_Orders_By_PROMO_CODES_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Orders_By_PROMO_CODES_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_PROMO_CODES_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_PROMO_CODES_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Orders_By_TENANT_ID(Params_Delete_Orders_By_TENANT_ID i_Params_Delete_Orders_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);

            await _orderRepository.Delete_Orders_By_TENANT_ID(i_Params_Delete_Orders_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Orders_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Orders_By_TENANTS_ID(Params_Delete_Orders_By_TENANTS_ID i_Params_Delete_Orders_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Orders_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);

            await _orderRepository.Delete_Orders_By_TENANTS_ID(i_Params_Delete_Orders_By_TENANTS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Orders_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Orders_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Orders_By_TENANTS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Orders(Orders i_Orders)
    {
        var operation = i_Orders.ORDERS_ID == -1 ? "Create New Orders" : "Update Existing Orders";

        try
        {
            _logger.LogInformation("Initiating Edit_Orders operation at the service layer: {Operation}.", operation);

            if (i_Orders.ORDERS_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Orders.ORDERS_ID.ToString() }, { "%2", "Edit_Orders" } });
            }

            i_Orders.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Orders.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Orders.ORDERS_ID == -1)
            {
                i_Orders.IS_DELETED = false;
            }

            await _orderRepository.Edit_Orders(i_Orders).ConfigureAwait(false);

            _logger.LogInformation("Edit_Orders operation at the service layer completed successfully: {Operation}. Orders ID: {Orders_id}", operation, i_Orders.ORDERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Orders_List(Params_Edit_Orders_List i_Params_Edit_Orders_List)
    {
        _logger.LogInformation("Initiating Edit_Orders_List operation at the repository layer.");

        if (i_Params_Edit_Orders_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Orders_List.List_To_Edit.Count());

            (i_Params_Edit_Orders_List.List_To_Edit, i_Params_Edit_Orders_List.List_Failed_Edit) = await i_Params_Edit_Orders_List.List_To_Edit.ProcessBatchOperations(
                Edit_Orders,
                oOrders => oOrders
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Orders_List.List_To_Edit.Count(), i_Params_Edit_Orders_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Orders_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Orders_List.List_To_Delete.Count());

            (i_Params_Edit_Orders_List.List_To_Delete, i_Params_Edit_Orders_List.List_Failed_Delete) = await i_Params_Edit_Orders_List.List_To_Delete.ProcessBatchOperations(
                async oOrders_ID => await Delete_Orders(new() { ORDERS_ID = oOrders_ID }).ConfigureAwait(false),
                oOrders_ID => oOrders_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Orders_List.List_To_Delete.Count(), i_Params_Edit_Orders_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Orders_List operation at the repository layer completed successfully.");
    }
}
