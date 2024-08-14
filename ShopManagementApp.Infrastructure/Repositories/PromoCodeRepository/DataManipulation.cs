using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.PromoCode;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class PromoCodeRepository
{
    public async Task Delete_Promo_codes(Params_Delete_Promo_codes i_Params_Delete_Promo_codes)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Promo_codes);
            await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Execute, "UP_DELETE_PROMO_CODES", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Promo_codes operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes);
            throw;
        }
    }

    public async Task Delete_Promo_codes_By_TENANT_ID(Params_Delete_Promo_codes_By_TENANT_ID i_Params_Delete_Promo_codes_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Promo_codes_By_TENANT_ID);
            await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Execute, "UP_DELETE_PROMO_CODES_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Promo_codes_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_Promo_codes_By_TENANTS_ID(Params_Delete_Promo_codes_By_TENANTS_ID i_Params_Delete_Promo_codes_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Promo_codes_By_TENANTS_ID);
            await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Execute, "UP_DELETE_PROMO_CODES_BY_TENANTS_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Promo_codes_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);
            throw;
        }
    }

    public async Task Edit_Promo_codes(Promo_codes i_Promo_codes)
    {
        var operation = i_Promo_codes.PROMO_CODES_ID == -1 ? "Create New Promo_codes" : "Update Existing Promo_codes";

        try
        {
            _logger.LogInformation("Initiating Edit_Promo_codes operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Promo_codes);
            _params.Add("PROMO_CODES_ID", i_Promo_codes.PROMO_CODES_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Promo_codes.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Promo_codes.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Promo_codes>(Enum_Operation_Type.Execute, "UP_EDIT_PROMO_CODES", _params).ConfigureAwait(false);

            i_Promo_codes.PROMO_CODES_ID = _params.Get<int>("PROMO_CODES_ID");
            i_Promo_codes.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Promo_codes.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Promo_codes operation at the repository layer completed successfully: {Operation}. Promo_codes ID: {PROMO_CODES_ID}", operation, i_Promo_codes.PROMO_CODES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }
}
