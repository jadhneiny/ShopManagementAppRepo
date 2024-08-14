using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class CommonRepository
{
    public async Task Delete_Tenants(Params_Delete_Tenants i_Params_Delete_Tenants)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenants operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenants);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Tenants);
            await _databaseContext.Execute<Tenants>(Enum_Operation_Type.Execute, "UP_DELETE_TENANTS", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Tenants operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenants);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenants operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenants);
            throw;
        }
    }

    public async Task Delete_Tenants_By_TENANT_ID(Params_Delete_Tenants_By_TENANT_ID i_Params_Delete_Tenants_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenants_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Tenants_By_TENANT_ID);
            await _databaseContext.Execute<Tenants>(Enum_Operation_Type.Execute, "UP_DELETE_TENANTS_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Tenants_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenants_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);
            throw;
        }
    }

    public async Task Edit_Tenants(Tenants i_Tenants)
    {
        var operation = i_Tenants.TENANTS_ID == -1 ? "Create New Tenants" : "Update Existing Tenants";

        try
        {
            _logger.LogInformation("Initiating Edit_Tenants operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Tenants);
            _params.Add("TENANTS_ID", i_Tenants.TENANTS_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Tenants.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Tenants.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Tenants>(Enum_Operation_Type.Execute, "UP_EDIT_TENANTS", _params).ConfigureAwait(false);

            i_Tenants.TENANTS_ID = _params.Get<int>("TENANTS_ID");
            i_Tenants.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Tenants.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Tenants operation at the repository layer completed successfully: {Operation}. Tenants ID: {TENANTS_ID}", operation, i_Tenants.TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }
}
