using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Common.Utilities;
using ShopManagementApp.Common.Exceptions;

namespace ShopManagementApp.Application.Services;

public partial class CommonService
{
    public async Task Delete_Tenants(Params_Delete_Tenants i_Params_Delete_Tenants)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenants operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenants);

            await _commonRepository.Delete_Tenants(i_Params_Delete_Tenants).ConfigureAwait(false);

            _logger.LogInformation("Delete_Tenants operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenants);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenants operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenants);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Tenants_By_TENANT_ID(Params_Delete_Tenants_By_TENANT_ID i_Params_Delete_Tenants_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenants_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);

            await _commonRepository.Delete_Tenants_By_TENANT_ID(i_Params_Delete_Tenants_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Tenants_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenants_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenants_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Tenants(Tenants i_Tenants)
    {
        var operation = i_Tenants.TENANTS_ID == -1 ? "Create New Tenants" : "Update Existing Tenants";

        try
        {
            _logger.LogInformation("Initiating Edit_Tenants operation at the service layer: {Operation}.", operation);

            if (i_Tenants.TENANTS_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Tenants.TENANTS_ID.ToString() }, { "%2", "Edit_Tenants" } });
            }

            i_Tenants.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Tenants.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Tenants.TENANTS_ID == -1)
            {
                i_Tenants.IS_DELETED = false;
            }

            await _commonRepository.Edit_Tenants(i_Tenants).ConfigureAwait(false);

            _logger.LogInformation("Edit_Tenants operation at the service layer completed successfully: {Operation}. Tenants ID: {Tenants_id}", operation, i_Tenants.TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Tenants_List(Params_Edit_Tenants_List i_Params_Edit_Tenants_List)
    {
        _logger.LogInformation("Initiating Edit_Tenants_List operation at the repository layer.");

        if (i_Params_Edit_Tenants_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Tenants_List.List_To_Edit.Count());

            (i_Params_Edit_Tenants_List.List_To_Edit, i_Params_Edit_Tenants_List.List_Failed_Edit) = await i_Params_Edit_Tenants_List.List_To_Edit.ProcessBatchOperations(
                Edit_Tenants,
                oTenants => oTenants
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Tenants_List.List_To_Edit.Count(), i_Params_Edit_Tenants_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Tenants_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Tenants_List.List_To_Delete.Count());

            (i_Params_Edit_Tenants_List.List_To_Delete, i_Params_Edit_Tenants_List.List_Failed_Delete) = await i_Params_Edit_Tenants_List.List_To_Delete.ProcessBatchOperations(
                async oTenants_ID => await Delete_Tenants(new() { TENANTS_ID = oTenants_ID }).ConfigureAwait(false),
                oTenants_ID => oTenants_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Tenants_List.List_To_Delete.Count(), i_Params_Edit_Tenants_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Tenants_List operation at the repository layer completed successfully.");
    }
}
