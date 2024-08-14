using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Address;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class AddressRepository
{
    public async Task Delete_Addresses(Params_Delete_Addresses i_Params_Delete_Addresses)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Addresses);
            await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Execute, "UP_DELETE_ADDRESSES", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Addresses operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses);
            throw;
        }
    }

    public async Task Delete_Addresses_By_CUSTOMERS_ID(Params_Delete_Addresses_By_CUSTOMERS_ID i_Params_Delete_Addresses_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Addresses_By_CUSTOMERS_ID);
            await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Execute, "UP_DELETE_ADDRESSES_BY_CUSTOMERS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Addresses_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task Delete_Addresses_By_TENANT_ID(Params_Delete_Addresses_By_TENANT_ID i_Params_Delete_Addresses_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Addresses_By_TENANT_ID);
            await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Execute, "UP_DELETE_ADDRESSES_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Addresses_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);
            throw;
        }
    }

    public async Task Edit_Addresses(Addresses i_Addresses)
    {
        var operation = i_Addresses.ADDRESSES_ID == -1 ? "Create New Addresses" : "Update Existing Addresses";

        try
        {
            _logger.LogInformation("Initiating Edit_Addresses operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Addresses);
            _params.Add("ADDRESSES_ID", i_Addresses.ADDRESSES_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Addresses.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Addresses.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Execute, "UP_EDIT_ADDRESSES", _params).ConfigureAwait(false);

            i_Addresses.ADDRESSES_ID = _params.Get<int>("ADDRESSES_ID");
            i_Addresses.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Addresses.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Addresses operation at the repository layer completed successfully: {Operation}. Addresses ID: {ADDRESSES_ID}", operation, i_Addresses.ADDRESSES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }
}
