using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Domain.Business;
using ShopManagementApp.Common.Utilities;
using ShopManagementApp.Common.Exceptions;

namespace ShopManagementApp.Application.Services;

public partial class BusinessService
{
    public async Task Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup);

            await _businessRepository.Delete_Setup(i_Params_Delete_Setup).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Setup_By_SETUP_CATEGORY_ID(Params_Delete_Setup_By_SETUP_CATEGORY_ID i_Params_Delete_Setup_By_SETUP_CATEGORY_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_SETUP_CATEGORY_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);

            await _businessRepository.Delete_Setup_By_SETUP_CATEGORY_ID(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup_By_SETUP_CATEGORY_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_SETUP_CATEGORY_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);

            await _businessRepository.Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Setup_By_TENANT_ID(Params_Delete_Setup_By_TENANT_ID i_Params_Delete_Setup_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);

            await _businessRepository.Delete_Setup_By_TENANT_ID(i_Params_Delete_Setup_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Setup(Setup i_Setup)
    {
        var operation = i_Setup.SETUP_ID == -1 ? "Create New Setup" : "Update Existing Setup";

        try
        {
            _logger.LogInformation("Initiating Edit_Setup operation at the service layer: {Operation}.", operation);

            if (i_Setup.SETUP_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Setup.SETUP_ID.ToString() }, { "%2", "Edit_Setup" } });
            }

            i_Setup.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Setup.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Setup.SETUP_ID == -1)
            {
                i_Setup.IS_DELETED = false;
            }

            await _businessRepository.Edit_Setup(i_Setup).ConfigureAwait(false);

            _logger.LogInformation("Edit_Setup operation at the service layer completed successfully: {Operation}. Setup ID: {Setup_id}", operation, i_Setup.SETUP_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Setup_List(Params_Edit_Setup_List i_Params_Edit_Setup_List)
    {
        _logger.LogInformation("Initiating Edit_Setup_List operation at the repository layer.");

        if (i_Params_Edit_Setup_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Setup_List.List_To_Edit.Count());

            (i_Params_Edit_Setup_List.List_To_Edit, i_Params_Edit_Setup_List.List_Failed_Edit) = await i_Params_Edit_Setup_List.List_To_Edit.ProcessBatchOperations(
                Edit_Setup,
                oSetup => oSetup
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Setup_List.List_To_Edit.Count(), i_Params_Edit_Setup_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Setup_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Setup_List.List_To_Delete.Count());

            (i_Params_Edit_Setup_List.List_To_Delete, i_Params_Edit_Setup_List.List_Failed_Delete) = await i_Params_Edit_Setup_List.List_To_Delete.ProcessBatchOperations(
                async oSetup_ID => await Delete_Setup(new() { SETUP_ID = oSetup_ID }).ConfigureAwait(false),
                oSetup_ID => oSetup_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Setup_List.List_To_Delete.Count(), i_Params_Edit_Setup_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Setup_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_category operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_category);

            await _businessRepository.Delete_Setup_category(i_Params_Delete_Setup_category).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup_category operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_category);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_category operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_category);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Setup_category_By_TENANT_ID(Params_Delete_Setup_category_By_TENANT_ID i_Params_Delete_Setup_category_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_category_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);

            await _businessRepository.Delete_Setup_category_By_TENANT_ID(i_Params_Delete_Setup_category_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup_category_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_category_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Setup_category(Setup_category i_Setup_category)
    {
        var operation = i_Setup_category.SETUP_CATEGORY_ID == -1 ? "Create New Setup_category" : "Update Existing Setup_category";

        try
        {
            _logger.LogInformation("Initiating Edit_Setup_category operation at the service layer: {Operation}.", operation);

            if (i_Setup_category.SETUP_CATEGORY_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Setup_category.SETUP_CATEGORY_ID.ToString() }, { "%2", "Edit_Setup_category" } });
            }

            i_Setup_category.TENANT_ID = _userSessionContext.Tenant_ID;
            i_Setup_category.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Setup_category.SETUP_CATEGORY_ID == -1)
            {
                i_Setup_category.IS_DELETED = false;
            }

            await _businessRepository.Edit_Setup_category(i_Setup_category).ConfigureAwait(false);

            _logger.LogInformation("Edit_Setup_category operation at the service layer completed successfully: {Operation}. Setup_category ID: {Setup_category_id}", operation, i_Setup_category.SETUP_CATEGORY_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Setup_category_List(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List)
    {
        _logger.LogInformation("Initiating Edit_Setup_category_List operation at the repository layer.");

        if (i_Params_Edit_Setup_category_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Setup_category_List.List_To_Edit.Count());

            (i_Params_Edit_Setup_category_List.List_To_Edit, i_Params_Edit_Setup_category_List.List_Failed_Edit) = await i_Params_Edit_Setup_category_List.List_To_Edit.ProcessBatchOperations(
                Edit_Setup_category,
                oSetup_category => oSetup_category
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Setup_category_List.List_To_Edit.Count(), i_Params_Edit_Setup_category_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Setup_category_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Setup_category_List.List_To_Delete.Count());

            (i_Params_Edit_Setup_category_List.List_To_Delete, i_Params_Edit_Setup_category_List.List_Failed_Delete) = await i_Params_Edit_Setup_category_List.List_To_Delete.ProcessBatchOperations(
                async oSetup_category_ID => await Delete_Setup_category(new() { SETUP_CATEGORY_ID = oSetup_category_ID }).ConfigureAwait(false),
                oSetup_category_ID => oSetup_category_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Setup_category_List.List_To_Delete.Count(), i_Params_Edit_Setup_category_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Setup_category_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_Tenant(Params_Delete_Tenant i_Params_Delete_Tenant)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenant operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenant);

            await _businessRepository.Delete_Tenant(i_Params_Delete_Tenant).ConfigureAwait(false);

            _logger.LogInformation("Delete_Tenant operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenant);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenant operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenant);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_Tenant_By_IS_DELETED(Params_Delete_Tenant_By_IS_DELETED i_Params_Delete_Tenant_By_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenant_By_IS_DELETED operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);

            await _businessRepository.Delete_Tenant_By_IS_DELETED(i_Params_Delete_Tenant_By_IS_DELETED).ConfigureAwait(false);

            _logger.LogInformation("Delete_Tenant_By_IS_DELETED operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenant_By_IS_DELETED operation at the service layer with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_Tenant(Tenant i_Tenant)
    {
        var operation = i_Tenant.TENANT_ID == -1 ? "Create New Tenant" : "Update Existing Tenant";

        try
        {
            _logger.LogInformation("Initiating Edit_Tenant operation at the service layer: {Operation}.", operation);

            if (i_Tenant.TENANT_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_Tenant.TENANT_ID.ToString() }, { "%2", "Edit_Tenant" } });
            }

            i_Tenant.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_Tenant.TENANT_ID == -1)
            {
                i_Tenant.IS_DELETED = false;
            }

            await _businessRepository.Edit_Tenant(i_Tenant).ConfigureAwait(false);

            _logger.LogInformation("Edit_Tenant operation at the service layer completed successfully: {Operation}. Tenant ID: {Tenant_id}", operation, i_Tenant.TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_Tenant_List(Params_Edit_Tenant_List i_Params_Edit_Tenant_List)
    {
        _logger.LogInformation("Initiating Edit_Tenant_List operation at the repository layer.");

        if (i_Params_Edit_Tenant_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_Tenant_List.List_To_Edit.Count());

            (i_Params_Edit_Tenant_List.List_To_Edit, i_Params_Edit_Tenant_List.List_Failed_Edit) = await i_Params_Edit_Tenant_List.List_To_Edit.ProcessBatchOperations(
                Edit_Tenant,
                oTenant => oTenant
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_Tenant_List.List_To_Edit.Count(), i_Params_Edit_Tenant_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_Tenant_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_Tenant_List.List_To_Delete.Count());

            (i_Params_Edit_Tenant_List.List_To_Delete, i_Params_Edit_Tenant_List.List_Failed_Delete) = await i_Params_Edit_Tenant_List.List_To_Delete.ProcessBatchOperations(
                async oTenant_ID => await Delete_Tenant(new() { TENANT_ID = oTenant_ID }).ConfigureAwait(false),
                oTenant_ID => oTenant_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_Tenant_List.List_To_Delete.Count(), i_Params_Edit_Tenant_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_Tenant_List operation at the repository layer completed successfully.");
    }

    public async Task Delete_User(Params_Delete_User i_Params_Delete_User)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User operation at the service layer with parameters: {@Params}.", i_Params_Delete_User);

            await _businessRepository.Delete_User(i_Params_Delete_User).ConfigureAwait(false);

            _logger.LogInformation("Delete_User operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User operation at the service layer with parameters: {@Params}.", i_Params_Delete_User);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_User_By_EMAIL_TENANT_ID(Params_Delete_User_By_EMAIL_TENANT_ID i_Params_Delete_User_By_EMAIL_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_EMAIL_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);

            await _businessRepository.Delete_User_By_EMAIL_TENANT_ID(i_Params_Delete_User_By_EMAIL_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_User_By_EMAIL_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_EMAIL_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_User_By_TENANT_ID(Params_Delete_User_By_TENANT_ID i_Params_Delete_User_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);

            await _businessRepository.Delete_User_By_TENANT_ID(i_Params_Delete_User_By_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_User_By_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_User_By_TENANT_ID_IS_DELETED(Params_Delete_User_By_TENANT_ID_IS_DELETED i_Params_Delete_User_By_TENANT_ID_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_TENANT_ID_IS_DELETED operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);

            await _businessRepository.Delete_User_By_TENANT_ID_IS_DELETED(i_Params_Delete_User_By_TENANT_ID_IS_DELETED).ConfigureAwait(false);

            _logger.LogInformation("Delete_User_By_TENANT_ID_IS_DELETED operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_TENANT_ID_IS_DELETED operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_User_By_USER_TYPE_SETUP_ID(Params_Delete_User_By_USER_TYPE_SETUP_ID i_Params_Delete_User_By_USER_TYPE_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_USER_TYPE_SETUP_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);

            await _businessRepository.Delete_User_By_USER_TYPE_SETUP_ID(i_Params_Delete_User_By_USER_TYPE_SETUP_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_User_By_USER_TYPE_SETUP_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_USER_TYPE_SETUP_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Delete_User_By_USERNAME_TENANT_ID(Params_Delete_User_By_USERNAME_TENANT_ID i_Params_Delete_User_By_USERNAME_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_USERNAME_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);

            await _businessRepository.Delete_User_By_USERNAME_TENANT_ID(i_Params_Delete_User_By_USERNAME_TENANT_ID).ConfigureAwait(false);

            _logger.LogInformation("Delete_User_By_USERNAME_TENANT_ID operation at the service layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_USERNAME_TENANT_ID operation at the service layer with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleDeleteException();
            throw;
        }
    }

    public async Task Edit_User(User i_User)
    {
        var operation = i_User.USER_ID == -1 ? "Create New User" : "Update Existing User";

        try
        {
            _logger.LogInformation("Initiating Edit_User operation at the service layer: {Operation}.", operation);

            if (i_User.USER_ID is 0 or < -1)
            {
                throw new PlatformException(Enum_Message_Code.InvalidPrimaryKey, new() { { "%1", i_User.USER_ID.ToString() }, { "%2", "Edit_User" } });
            }

            i_User.TENANT_ID = _userSessionContext.Tenant_ID;
            i_User.LAST_UPDATED_BY_USER_ID = _userSessionContext.User_ID;

            if (i_User.USER_ID == -1)
            {
                i_User.IS_DELETED = false;
            }

            await _businessRepository.Edit_User(i_User).ConfigureAwait(false);

            _logger.LogInformation("Edit_User operation at the service layer completed successfully: {Operation}. User ID: {User_id}", operation, i_User.USER_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the service layer.", operation);
            await _databaseContext.RollbackAsync().ConfigureAwait(false);
            ex.HandleEditException();
            throw;
        }
    }

    public async Task Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
    {
        _logger.LogInformation("Initiating Edit_User_List operation at the repository layer.");

        if (i_Params_Edit_User_List.List_To_Edit?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch edit for {EditEntiesCount} entries.", i_Params_Edit_User_List.List_To_Edit.Count());

            (i_Params_Edit_User_List.List_To_Edit, i_Params_Edit_User_List.List_Failed_Edit) = await i_Params_Edit_User_List.List_To_Edit.ProcessBatchOperations(
                Edit_User,
                oUser => oUser
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch edit completed. Success: {SuccessfulEditCount}, Failed: {FailedEditCount}.", i_Params_Edit_User_List.List_To_Edit.Count(), i_Params_Edit_User_List.List_Failed_Edit.Count());
        }

        if (i_Params_Edit_User_List.List_To_Delete?.Any() ?? false)
        {
            _logger.LogInformation("Processing batch delete for {DeleteEntiesCount} entries.", i_Params_Edit_User_List.List_To_Delete.Count());

            (i_Params_Edit_User_List.List_To_Delete, i_Params_Edit_User_List.List_Failed_Delete) = await i_Params_Edit_User_List.List_To_Delete.ProcessBatchOperations(
                async oUser_ID => await Delete_User(new() { USER_ID = oUser_ID }).ConfigureAwait(false),
                oUser_ID => oUser_ID
            ).ConfigureAwait(false);

            _logger.LogInformation("Batch delete completed. Success: {SuccessfulDeleteCount}, Failed: {FailedDeleteCount}.", i_Params_Edit_User_List.List_To_Delete.Count(), i_Params_Edit_User_List.List_Failed_Delete.Count());
        }

        _logger.LogInformation("Edit_User_List operation at the repository layer completed successfully.");
    }
}
