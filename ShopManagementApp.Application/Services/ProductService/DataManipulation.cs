using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Domain.Product;
using ShopManagementApp.Common.Utilities;
using ShopManagementApp.Common.Exceptions;

namespace ShopManagementApp.Application.Services;

public partial class ProductService
{
    public async Task Delete_Products(Params_Delete_Products i_Params_Delete_Products)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products);

            await _productRepository.Delete_Products(i_Params_Delete_Products).ConfigureAwait(false);

            _logger.LogInformation("Delete_Products operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Products_By_SHOPS_ID(Params_Delete_Products_By_SHOPS_ID i_Params_Delete_Products_By_SHOPS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_SHOPS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);

            await _productRepository.Delete_Products_By_SHOPS_ID(i_Params_Delete_Products_By_SHOPS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Products_By_SHOPS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_SHOPS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Products_By_TENANT_ID(Params_Delete_Products_By_TENANT_ID i_Params_Delete_Products_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);

            await _productRepository.Delete_Products_By_TENANT_ID(i_Params_Delete_Products_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Products_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Products_By_TENANTS_ID(Params_Delete_Products_By_TENANTS_ID i_Params_Delete_Products_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);

            await _productRepository.Delete_Products_By_TENANTS_ID(i_Params_Delete_Products_By_TENANTS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Products_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Products(Products i_Products)
    {
        var operation = i_Products.PRODUCTS_ID == -1 ? "Create New Products" : "Update Existing Products";

        try
        {
            _logger.LogInformation("Initiating Edit_Products operation at the service layer: {Operation}.", operation);

            if (i_Products.PRODUCTS_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Products.PRODUCTS_ID.ToString() }, { "%2", "Edit_Products" } });
            }

            i_Products.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Products.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Products.PRODUCTS_ID == -1)
            {
                i_Products.IS_DELETED = false;
            }

            await _productRepository.Edit_Products(i_Products).ConfigureAwait(false);

            _logger.LogInformation("Edit_Products operation at the service layer completed successfully: {Operation}. Products ID: {Products_id}", operation, i_Products.PRODUCTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Products_List(Params_Edit_Products_List i_Params_Edit_Products_List)
    {
        _logger.LogInformation("Initiating Edit_Products_List operation at the repository layer.");

        if (i_Params_Edit_Products_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Products_List.List_To_Edit.Count());

            (i_Params_Edit_Products_List.List_To_Edit, i_Params_Edit_Products_List.List_Failed_Edit) = await i_Params_Edit_Products_List.List_To_Edit.ProcessBatchOperations(
                Edit_Products,
                oProducts => oProducts
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Products_List.List_To_Edit.Count(), i_Params_Edit_Products_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Products_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Products_List.List_To_Delete.Count());

            (i_Params_Edit_Products_List.List_To_Delete, i_Params_Edit_Products_List.List_Failed_Delete) = await i_Params_Edit_Products_List.List_To_Delete.ProcessBatchOperations(
                async oProducts_ID => await Delete_Products(new() { PRODUCTS_ID = oProducts_ID }).ConfigureAwait(false),
                oProducts_ID => oProducts_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Products_List.List_To_Delete.Count(), i_Params_Edit_Products_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Products_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Shops(Params_Delete_Shops i_Params_Delete_Shops)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops);

            await _productRepository.Delete_Shops(i_Params_Delete_Shops).ConfigureAwait(false);

            _logger.LogInformation("Delete_Shops operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Shops_By_TENANT_ID(Params_Delete_Shops_By_TENANT_ID i_Params_Delete_Shops_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);

            await _productRepository.Delete_Shops_By_TENANT_ID(i_Params_Delete_Shops_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Shops_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Shops_By_TENANTS_ID(Params_Delete_Shops_By_TENANTS_ID i_Params_Delete_Shops_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);

            await _productRepository.Delete_Shops_By_TENANTS_ID(i_Params_Delete_Shops_By_TENANTS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Shops_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Shops(Shops i_Shops)
    {
        var operation = i_Shops.SHOPS_ID == -1 ? "Create New Shops" : "Update Existing Shops";

        try
        {
            _logger.LogInformation("Initiating Edit_Shops operation at the service layer: {Operation}.", operation);

            if (i_Shops.SHOPS_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Shops.SHOPS_ID.ToString() }, { "%2", "Edit_Shops" } });
            }

            i_Shops.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Shops.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Shops.SHOPS_ID == -1)
            {
                i_Shops.IS_DELETED = false;
            }

            await _productRepository.Edit_Shops(i_Shops).ConfigureAwait(false);

            _logger.LogInformation("Edit_Shops operation at the service layer completed successfully: {Operation}. Shops ID: {Shops_id}", operation, i_Shops.SHOPS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Shops_List(Params_Edit_Shops_List i_Params_Edit_Shops_List)
    {
        _logger.LogInformation("Initiating Edit_Shops_List operation at the repository layer.");

        if (i_Params_Edit_Shops_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Shops_List.List_To_Edit.Count());

            (i_Params_Edit_Shops_List.List_To_Edit, i_Params_Edit_Shops_List.List_Failed_Edit) = await i_Params_Edit_Shops_List.List_To_Edit.ProcessBatchOperations(
                Edit_Shops,
                oShops => oShops
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Shops_List.List_To_Edit.Count(), i_Params_Edit_Shops_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Shops_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Shops_List.List_To_Delete.Count());

            (i_Params_Edit_Shops_List.List_To_Delete, i_Params_Edit_Shops_List.List_Failed_Delete) = await i_Params_Edit_Shops_List.List_To_Delete.ProcessBatchOperations(
                async oShops_ID => await Delete_Shops(new() { SHOPS_ID = oShops_ID }).ConfigureAwait(false),
                oShops_ID => oShops_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Shops_List.List_To_Delete.Count(), i_Params_Edit_Shops_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Shops_List operation at the repository layer completed successfully.");
    }
}
