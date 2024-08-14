using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.UserManagement;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class UserManagementRepository
{
    public async Task Delete_Admins(Params_Delete_Admins i_Params_Delete_Admins)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Admins);
            await _databaseContext.Execute<Admins>(Enum_Operation_Type.Execute, "UP_DELETE_ADMINS", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Admins operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins);
            throw;
        }
    }

    public async Task Delete_Admins_By_TENANT_ID(Params_Delete_Admins_By_TENANT_ID i_Params_Delete_Admins_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Admins_By_TENANT_ID);
            await _databaseContext.Execute<Admins>(Enum_Operation_Type.Execute, "UP_DELETE_ADMINS_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Admins_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Admins_By_TENANTS_ID(Params_Delete_Admins_By_TENANTS_ID i_Params_Delete_Admins_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Admins_By_TENANTS_ID);
            await _databaseContext.Execute<Admins>(Enum_Operation_Type.Execute, "UP_DELETE_ADMINS_BY_TENANTS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Admins_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Admins(Admins i_Admins)
    {
        var operation = i_Admins.ADMINS_ID == -1 ? "Create New Admins" : "Update Existing Admins";

        try
        {
            _logger.LogInformation("Initiating Edit_Admins operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Admins);
            _params.Add("ADMINS_ID", i_Admins.ADMINS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Admins.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Admins.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Admins>(Enum_Operation_Type.Execute, "UP_EDIT_ADMINS", _params).ConfigureAwait(false);

            i_Admins.ADMINS_ID = _params.Get<int>("ADMINS_ID");
            i_Admins.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Admins.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Admins operation at the repository layer completed successfully: {Operation}. Admins ID: {ADMINS_ID}", operation, i_Admins.ADMINS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Customers(Params_Delete_Customers i_Params_Delete_Customers)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Customers);
            await _databaseContext.Execute<Customers>(Enum_Operation_Type.Execute, "UP_DELETE_CUSTOMERS", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Customers operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers);
            throw;
        }
    }

    public async Task Delete_Customers_By_TENANT_ID(Params_Delete_Customers_By_TENANT_ID i_Params_Delete_Customers_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Customers_By_TENANT_ID);
            await _databaseContext.Execute<Customers>(Enum_Operation_Type.Execute, "UP_DELETE_CUSTOMERS_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Customers_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Customers_By_TENANTS_ID(Params_Delete_Customers_By_TENANTS_ID i_Params_Delete_Customers_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Customers_By_TENANTS_ID);
            await _databaseContext.Execute<Customers>(Enum_Operation_Type.Execute, "UP_DELETE_CUSTOMERS_BY_TENANTS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Customers_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Customers(Customers i_Customers)
    {
        var operation = i_Customers.CUSTOMERS_ID == -1 ? "Create New Customers" : "Update Existing Customers";

        try
        {
            _logger.LogInformation("Initiating Edit_Customers operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Customers);
            _params.Add("CUSTOMERS_ID", i_Customers.CUSTOMERS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Customers.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Customers.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Customers>(Enum_Operation_Type.Execute, "UP_EDIT_CUSTOMERS", _params).ConfigureAwait(false);

            i_Customers.CUSTOMERS_ID = _params.Get<int>("CUSTOMERS_ID");
            i_Customers.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Customers.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Customers operation at the repository layer completed successfully: {Operation}. Customers ID: {CUSTOMERS_ID}", operation, i_Customers.CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }
}
