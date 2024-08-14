using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Domain.Address;
using ShopManagementApp.Common.Utilities;
using ShopManagementApp.Common.Exceptions;

namespace ShopManagementApp.Application.Services;

public partial class AddressService
{
    public async Task Delete_Addresses(Params_Delete_Addresses i_Params_Delete_Addresses)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses);

            await _addressRepository.Delete_Addresses(i_Params_Delete_Addresses).ConfigureAwait(false);

            _logger.LogInformation("Delete_Addresses operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Addresses_By_CUSTOMERS_ID(Params_Delete_Addresses_By_CUSTOMERS_ID i_Params_Delete_Addresses_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses_By_CUSTOMERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);

            await _addressRepository.Delete_Addresses_By_CUSTOMERS_ID(i_Params_Delete_Addresses_By_CUSTOMERS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Addresses_By_CUSTOMERS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses_By_CUSTOMERS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_CUSTOMERS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Addresses_By_TENANT_ID(Params_Delete_Addresses_By_TENANT_ID i_Params_Delete_Addresses_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Addresses_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);

            await _addressRepository.Delete_Addresses_By_TENANT_ID(i_Params_Delete_Addresses_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Addresses_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Addresses_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Addresses_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Addresses(Addresses i_Addresses)
    {
        var operation = i_Addresses.ADDRESSES_ID == -1 ? "Create New Addresses" : "Update Existing Addresses";

        try
        {
            _logger.LogInformation("Initiating Edit_Addresses operation at the service layer: {Operation}.", operation);

            if (i_Addresses.ADDRESSES_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Addresses.ADDRESSES_ID.ToString() }, { "%2", "Edit_Addresses" } });
            }

            i_Addresses.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Addresses.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Addresses.ADDRESSES_ID == -1)
            {
                i_Addresses.IS_DELETED = false;
            }

            await _addressRepository.Edit_Addresses(i_Addresses).ConfigureAwait(false);

            _logger.LogInformation("Edit_Addresses operation at the service layer completed successfully: {Operation}. Addresses ID: {Addresses_id}", operation, i_Addresses.ADDRESSES_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Addresses_List(Params_Edit_Addresses_List i_Params_Edit_Addresses_List)
    {
        _logger.LogInformation("Initiating Edit_Addresses_List operation at the repository layer.");

        if (i_Params_Edit_Addresses_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Addresses_List.List_To_Edit.Count());

            (i_Params_Edit_Addresses_List.List_To_Edit, i_Params_Edit_Addresses_List.List_Failed_Edit) = await i_Params_Edit_Addresses_List.List_To_Edit.ProcessBatchOperations(
                Edit_Addresses,
                oAddresses => oAddresses
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Addresses_List.List_To_Edit.Count(), i_Params_Edit_Addresses_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Addresses_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Addresses_List.List_To_Delete.Count());

            (i_Params_Edit_Addresses_List.List_To_Delete, i_Params_Edit_Addresses_List.List_Failed_Delete) = await i_Params_Edit_Addresses_List.List_To_Delete.ProcessBatchOperations(
                async oAddresses_ID => await Delete_Addresses(new() { ADDRESSES_ID = oAddresses_ID }).ConfigureAwait(false),
                oAddresses_ID => oAddresses_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Addresses_List.List_To_Delete.Count(), i_Params_Edit_Addresses_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Addresses_List operation at the repository layer completed successfully.");
    }
}
