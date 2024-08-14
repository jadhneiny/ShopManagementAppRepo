using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Product;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class ProductRepository
{
    public async Task Delete_Products(Params_Delete_Products i_Params_Delete_Products)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Products);
            await _databaseContext.Execute<Products>(Enum_Operation_Type.Execute, "UP_DELETE_PRODUCTS", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Products operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products);
            throw;
        }
    }

    public async Task Delete_Products_By_SHOPS_ID(Params_Delete_Products_By_SHOPS_ID i_Params_Delete_Products_By_SHOPS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Products_By_SHOPS_ID);
            await _databaseContext.Execute<Products>(Enum_Operation_Type.Execute, "UP_DELETE_PRODUCTS_BY_SHOPS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Products_By_SHOPS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_SHOPS_ID);
            throw;
        }
    }

    public async Task Delete_Products_By_TENANT_ID(Params_Delete_Products_By_TENANT_ID i_Params_Delete_Products_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Products_By_TENANT_ID);
            await _databaseContext.Execute<Products>(Enum_Operation_Type.Execute, "UP_DELETE_PRODUCTS_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Products_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Products_By_TENANTS_ID(Params_Delete_Products_By_TENANTS_ID i_Params_Delete_Products_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Products_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Products_By_TENANTS_ID);
            await _databaseContext.Execute<Products>(Enum_Operation_Type.Execute, "UP_DELETE_PRODUCTS_BY_TENANTS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Products_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Products_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Products_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Products(Products i_Products)
    {
        var operation = i_Products.PRODUCTS_ID == -1 ? "Create New Products" : "Update Existing Products";

        try
        {
            _logger.LogInformation("Initiating Edit_Products operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Products);
            _params.Add("PRODUCTS_ID", i_Products.PRODUCTS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Products.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Products.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Products>(Enum_Operation_Type.Execute, "UP_EDIT_PRODUCTS", _params).ConfigureAwait(false);

            i_Products.PRODUCTS_ID = _params.Get<int>("PRODUCTS_ID");
            i_Products.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Products.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Products operation at the repository layer completed successfully: {Operation}. Products ID: {PRODUCTS_ID}", operation, i_Products.PRODUCTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Shops(Params_Delete_Shops i_Params_Delete_Shops)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Shops);
            await _databaseContext.Execute<Shops>(Enum_Operation_Type.Execute, "UP_DELETE_SHOPS", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Shops operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops);
            throw;
        }
    }

    public async Task Delete_Shops_By_TENANT_ID(Params_Delete_Shops_By_TENANT_ID i_Params_Delete_Shops_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Shops_By_TENANT_ID);
            await _databaseContext.Execute<Shops>(Enum_Operation_Type.Execute, "UP_DELETE_SHOPS_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Shops_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Shops_By_TENANTS_ID(Params_Delete_Shops_By_TENANTS_ID i_Params_Delete_Shops_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Shops_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Shops_By_TENANTS_ID);
            await _databaseContext.Execute<Shops>(Enum_Operation_Type.Execute, "UP_DELETE_SHOPS_BY_TENANTS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Shops_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Shops_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Shops_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Shops(Shops i_Shops)
    {
        var operation = i_Shops.SHOPS_ID == -1 ? "Create New Shops" : "Update Existing Shops";

        try
        {
            _logger.LogInformation("Initiating Edit_Shops operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Shops);
            _params.Add("SHOPS_ID", i_Shops.SHOPS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Shops.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Shops.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Shops>(Enum_Operation_Type.Execute, "UP_EDIT_SHOPS", _params).ConfigureAwait(false);

            i_Shops.SHOPS_ID = _params.Get<int>("SHOPS_ID");
            i_Shops.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Shops.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Shops operation at the repository layer completed successfully: {Operation}. Shops ID: {SHOPS_ID}", operation, i_Shops.SHOPS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }
}
