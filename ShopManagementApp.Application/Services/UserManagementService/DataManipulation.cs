using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Domain.UserManagement;
using ShopManagementApp.Common.Utilities;
using ShopManagementApp.Common.Exceptions;

namespace ShopManagementApp.Application.Services;

public partial class UserManagementService
{
    public async Task Delete_Admins(Params_Delete_Admins i_Params_Delete_Admins)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins);

            await _userManagementRepository.Delete_Admins(i_Params_Delete_Admins).ConfigureAwait(false);

            _logger.LogInformation("Delete_Admins operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Admins_By_TENANT_ID(Params_Delete_Admins_By_TENANT_ID i_Params_Delete_Admins_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);

            await _userManagementRepository.Delete_Admins_By_TENANT_ID(i_Params_Delete_Admins_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Admins_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Admins_By_TENANTS_ID(Params_Delete_Admins_By_TENANTS_ID i_Params_Delete_Admins_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Admins_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);

            await _userManagementRepository.Delete_Admins_By_TENANTS_ID(i_Params_Delete_Admins_By_TENANTS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Admins_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Admins_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Admins_By_TENANTS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Admins(Admins i_Admins)
    {
        var operation = i_Admins.ADMINS_ID == -1 ? "Create New Admins" : "Update Existing Admins";

        try
        {
            _logger.LogInformation("Initiating Edit_Admins operation at the service layer: {Operation}.", operation);

            if (i_Admins.ADMINS_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Admins.ADMINS_ID.ToString() }, { "%2", "Edit_Admins" } });
            }

            i_Admins.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Admins.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Admins.ADMINS_ID == -1)
            {
                i_Admins.IS_DELETED = false;
            }

            await _userManagementRepository.Edit_Admins(i_Admins).ConfigureAwait(false);

            _logger.LogInformation("Edit_Admins operation at the service layer completed successfully: {Operation}. Admins ID: {Admins_id}", operation, i_Admins.ADMINS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Admins_List(Params_Edit_Admins_List i_Params_Edit_Admins_List)
    {
        _logger.LogInformation("Initiating Edit_Admins_List operation at the repository layer.");

        if (i_Params_Edit_Admins_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Admins_List.List_To_Edit.Count());

            (i_Params_Edit_Admins_List.List_To_Edit, i_Params_Edit_Admins_List.List_Failed_Edit) = await i_Params_Edit_Admins_List.List_To_Edit.ProcessBatchOperations(
                Edit_Admins,
                oAdmins => oAdmins
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Admins_List.List_To_Edit.Count(), i_Params_Edit_Admins_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Admins_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Admins_List.List_To_Delete.Count());

            (i_Params_Edit_Admins_List.List_To_Delete, i_Params_Edit_Admins_List.List_Failed_Delete) = await i_Params_Edit_Admins_List.List_To_Delete.ProcessBatchOperations(
                async oAdmins_ID => await Delete_Admins(new() { ADMINS_ID = oAdmins_ID }).ConfigureAwait(false),
                oAdmins_ID => oAdmins_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Admins_List.List_To_Delete.Count(), i_Params_Edit_Admins_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Admins_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Customers(Params_Delete_Customers i_Params_Delete_Customers)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers);

            await _userManagementRepository.Delete_Customers(i_Params_Delete_Customers).ConfigureAwait(false);

            _logger.LogInformation("Delete_Customers operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Customers_By_TENANT_ID(Params_Delete_Customers_By_TENANT_ID i_Params_Delete_Customers_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);

            await _userManagementRepository.Delete_Customers_By_TENANT_ID(i_Params_Delete_Customers_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Customers_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Customers_By_TENANTS_ID(Params_Delete_Customers_By_TENANTS_ID i_Params_Delete_Customers_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Customers_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);

            await _userManagementRepository.Delete_Customers_By_TENANTS_ID(i_Params_Delete_Customers_By_TENANTS_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Customers_By_TENANTS_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Customers_By_TENANTS_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Customers_By_TENANTS_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Customers(Customers i_Customers)
    {
        var operation = i_Customers.CUSTOMERS_ID == -1 ? "Create New Customers" : "Update Existing Customers";

        try
        {
            _logger.LogInformation("Initiating Edit_Customers operation at the service layer: {Operation}.", operation);

            if (i_Customers.CUSTOMERS_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Customers.CUSTOMERS_ID.ToString() }, { "%2", "Edit_Customers" } });
            }

            i_Customers.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Customers.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Customers.CUSTOMERS_ID == -1)
            {
                i_Customers.IS_DELETED = false;
            }

            await _userManagementRepository.Edit_Customers(i_Customers).ConfigureAwait(false);

            _logger.LogInformation("Edit_Customers operation at the service layer completed successfully: {Operation}. Customers ID: {Customers_id}", operation, i_Customers.CUSTOMERS_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Customers_List(Params_Edit_Customers_List i_Params_Edit_Customers_List)
    {
        _logger.LogInformation("Initiating Edit_Customers_List operation at the repository layer.");

        if (i_Params_Edit_Customers_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Customers_List.List_To_Edit.Count());

            (i_Params_Edit_Customers_List.List_To_Edit, i_Params_Edit_Customers_List.List_Failed_Edit) = await i_Params_Edit_Customers_List.List_To_Edit.ProcessBatchOperations(
                Edit_Customers,
                oCustomers => oCustomers
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Customers_List.List_To_Edit.Count(), i_Params_Edit_Customers_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Customers_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Customers_List.List_To_Delete.Count());

            (i_Params_Edit_Customers_List.List_To_Delete, i_Params_Edit_Customers_List.List_Failed_Delete) = await i_Params_Edit_Customers_List.List_To_Delete.ProcessBatchOperations(
                async oCustomers_ID => await Delete_Customers(new() { CUSTOMERS_ID = oCustomers_ID }).ConfigureAwait(false),
                oCustomers_ID => oCustomers_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Customers_List.List_To_Delete.Count(), i_Params_Edit_Customers_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Customers_List operation at the repository layer completed successfully.");
    }
}
