using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Domain.PromoCode;
using ShopManagementApp.Common.Utilities;
using ShopManagementApp.Common.Exceptions;

namespace ShopManagementApp.Application.Services;

public partial class PromoCodeService
{
    public async Task Delete_Promo_codes(Params_Delete_Promo_codes i_Params_Delete_Promo_codes)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes);

            await _promoCodeRepository.Delete_Promo_codes(i_Params_Delete_Promo_codes).ConfigureAwait(false);

            _logger.LogInformation("Delete_Promo_codes operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Promo_codes_By_TENANT_ID(Params_Delete_Promo_codes_By_TENANT_ID i_Params_Delete_Promo_codes_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);

            await _promoCodeRepository.Delete_Promo_codes_By_TENANT_ID(i_Params_Delete_Promo_codes_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Promo_codes_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Promo_codes_By_TENANTS_ID(Params_Delete_Promo_codes_By_TENANTS_ID i_Params_Delete_Promo_codes_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Promo_codes_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);

            await _promoCodeRepository.Delete_Promo_codes_By_TENANTS_ID(i_Params_Delete_Promo_codes_By_TENANTS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Promo_codes_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Promo_codes_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Promo_codes_By_TENANTS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Promo_codes(Promo_codes i_Promo_codes)
    {
        var operation = i_Promo_codes.PROMO_CODES_ID == -1 ? "Create New Promo_codes" : "Update Existing Promo_codes";

        try
        {
            _logger.LogInformation("Initiating Edit_Promo_codes operation at the service layer: {Operation}.", operation);

            if (i_Promo_codes.PROMO_CODES_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Promo_codes.PROMO_CODES_ID.ToString() }, { "%2", "Edit_Promo_codes" } });
            }

            i_Promo_codes.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Promo_codes.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Promo_codes.PROMO_CODES_ID == -1)
            {
                i_Promo_codes.IS_DELETED = false;
            }

            await _promoCodeRepository.Edit_Promo_codes(i_Promo_codes).ConfigureAwait(false);

            _logger.LogInformation("Edit_Promo_codes operation at the service layer completed successfully: {Operation}. Promo_codes ID: {Promo_codes_id}", operation, i_Promo_codes.PROMO_CODES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Promo_codes_List(Params_Edit_Promo_codes_List i_Params_Edit_Promo_codes_List)
    {
        _logger.LogInformation("Initiating Edit_Promo_codes_List operation at the repository layer.");

        if (i_Params_Edit_Promo_codes_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Promo_codes_List.List_To_Edit.Count());

            (i_Params_Edit_Promo_codes_List.List_To_Edit, i_Params_Edit_Promo_codes_List.List_Failed_Edit) = await i_Params_Edit_Promo_codes_List.List_To_Edit.ProcessBatchOperations(
                Edit_Promo_codes,
                oPromo_codes => oPromo_codes
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Promo_codes_List.List_To_Edit.Count(), i_Params_Edit_Promo_codes_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Promo_codes_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Promo_codes_List.List_To_Delete.Count());

            (i_Params_Edit_Promo_codes_List.List_To_Delete, i_Params_Edit_Promo_codes_List.List_Failed_Delete) = await i_Params_Edit_Promo_codes_List.List_To_Delete.ProcessBatchOperations(
                async oPromo_codes_ID => await Delete_Promo_codes(new() { PROMO_CODES_ID = oPromo_codes_ID }).ConfigureAwait(false),
                oPromo_codes_ID => oPromo_codes_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Promo_codes_List.List_To_Delete.Count(), i_Params_Edit_Promo_codes_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Promo_codes_List operation at the repository layer completed successfully.");
    }
}
