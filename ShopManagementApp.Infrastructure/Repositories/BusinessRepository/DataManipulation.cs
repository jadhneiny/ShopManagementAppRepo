using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Business;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class BusinessRepository
{
    public async Task Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup);
            await _databaseContext.Execute<Setup>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup);
            throw;
        }
    }

    public async Task Delete_Setup_By_SETUP_CATEGORY_ID(Params_Delete_Setup_By_SETUP_CATEGORY_ID i_Params_Delete_Setup_By_SETUP_CATEGORY_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
            await _databaseContext.Execute<Setup>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP_BY_SETUP_CATEGORY_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup_By_SETUP_CATEGORY_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
            throw;
        }
    }

    public async Task Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
            await _databaseContext.Execute<Setup>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
            throw;
        }
    }

    public async Task Delete_Setup_By_TENANT_ID(Params_Delete_Setup_By_TENANT_ID i_Params_Delete_Setup_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup_By_TENANT_ID);
            await _databaseContext.Execute<Setup>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_By_TENANT_ID);
            throw;
        }
    }

    public async Task Edit_Setup(Setup i_Setup)
    {
        var operation = i_Setup.SETUP_ID == -1 ? "Create New Setup" : "Update Existing Setup";

        try
        {
            _logger.LogInformation("Initiating Edit_Setup operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Setup);
            _params.Add("SETUP_ID", i_Setup.SETUP_ID, DbType.Int64, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Setup.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Setup.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Setup>(Enum_Operation_Type.Execute, "UP_EDIT_SETUP", _params).ConfigureAwait(false);

            i_Setup.SETUP_ID = _params.Get<long>("SETUP_ID");
            i_Setup.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Setup.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Setup operation at the repository layer completed successfully: {Operation}. Setup ID: {SETUP_ID}", operation, i_Setup.SETUP_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_category operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_category);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup_category);
            await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP_CATEGORY", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup_category operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_category);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_category operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_category);
            throw;
        }
    }

    public async Task Delete_Setup_category_By_TENANT_ID(Params_Delete_Setup_category_By_TENANT_ID i_Params_Delete_Setup_category_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Setup_category_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Setup_category_By_TENANT_ID);
            await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Execute, "UP_DELETE_SETUP_CATEGORY_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Setup_category_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Setup_category_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Setup_category_By_TENANT_ID);
            throw;
        }
    }

    public async Task Edit_Setup_category(Setup_category i_Setup_category)
    {
        var operation = i_Setup_category.SETUP_CATEGORY_ID == -1 ? "Create New Setup_category" : "Update Existing Setup_category";

        try
        {
            _logger.LogInformation("Initiating Edit_Setup_category operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Setup_category);
            _params.Add("SETUP_CATEGORY_ID", i_Setup_category.SETUP_CATEGORY_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Setup_category.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Setup_category.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Execute, "UP_EDIT_SETUP_CATEGORY", _params).ConfigureAwait(false);

            i_Setup_category.SETUP_CATEGORY_ID = _params.Get<int>("SETUP_CATEGORY_ID");
            i_Setup_category.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Setup_category.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Setup_category operation at the repository layer completed successfully: {Operation}. Setup_category ID: {SETUP_CATEGORY_ID}", operation, i_Setup_category.SETUP_CATEGORY_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_Tenant(Params_Delete_Tenant i_Params_Delete_Tenant)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenant operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenant);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Tenant);
            await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Execute, "UP_DELETE_TENANT", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Tenant operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenant);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenant operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenant);
            throw;
        }
    }

    public async Task Delete_Tenant_By_IS_DELETED(Params_Delete_Tenant_By_IS_DELETED i_Params_Delete_Tenant_By_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_Tenant_By_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_Tenant_By_IS_DELETED);
            await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Execute, "UP_DELETE_TENANT_BY_IS_DELETED", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_Tenant_By_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_Tenant_By_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Delete_Tenant_By_IS_DELETED);
            throw;
        }
    }

    public async Task Edit_Tenant(Tenant i_Tenant)
    {
        var operation = i_Tenant.TENANT_ID == -1 ? "Create New Tenant" : "Update Existing Tenant";

        try
        {
            _logger.LogInformation("Initiating Edit_Tenant operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_Tenant);
            _params.Add("TENANT_ID", i_Tenant.TENANT_ID, DbType.Int32, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_Tenant.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_Tenant.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Execute, "UP_EDIT_TENANT", _params).ConfigureAwait(false);

            i_Tenant.TENANT_ID = _params.Get<int>("TENANT_ID");
            i_Tenant.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_Tenant.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_Tenant operation at the repository layer completed successfully: {Operation}. Tenant ID: {TENANT_ID}", operation, i_Tenant.TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }

    public async Task Delete_User(Params_Delete_User i_Params_Delete_User)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_User operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User);
            throw;
        }
    }

    public async Task Delete_User_By_EMAIL_TENANT_ID(Params_Delete_User_By_EMAIL_TENANT_ID i_Params_Delete_User_By_EMAIL_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_EMAIL_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User_By_EMAIL_TENANT_ID);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER_BY_EMAIL_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_User_By_EMAIL_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_EMAIL_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_EMAIL_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_User_By_TENANT_ID(Params_Delete_User_By_TENANT_ID i_Params_Delete_User_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User_By_TENANT_ID);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER_BY_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_User_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID);
            throw;
        }
    }

    public async Task Delete_User_By_TENANT_ID_IS_DELETED(Params_Delete_User_By_TENANT_ID_IS_DELETED i_Params_Delete_User_By_TENANT_ID_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_TENANT_ID_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER_BY_TENANT_ID_IS_DELETED", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_User_By_TENANT_ID_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_TENANT_ID_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
            throw;
        }
    }

    public async Task Delete_User_By_USER_TYPE_SETUP_ID(Params_Delete_User_By_USER_TYPE_SETUP_ID i_Params_Delete_User_By_USER_TYPE_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_USER_TYPE_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER_BY_USER_TYPE_SETUP_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_User_By_USER_TYPE_SETUP_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_USER_TYPE_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
            throw;
        }
    }

    public async Task Delete_User_By_USERNAME_TENANT_ID(Params_Delete_User_By_USERNAME_TENANT_ID i_Params_Delete_User_By_USERNAME_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Delete_User_By_USERNAME_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Delete_User_By_USERNAME_TENANT_ID);
            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_DELETE_USER_BY_USERNAME_TENANT_ID", _params).ConfigureAwait(false);

            _logger.LogInformation("Delete_User_By_USERNAME_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Delete_User_By_USERNAME_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Delete_User_By_USERNAME_TENANT_ID);
            throw;
        }
    }

    public async Task Edit_User(User i_User)
    {
        var operation = i_User.USER_ID == -1 ? "Create New User" : "Update Existing User";

        try
        {
            _logger.LogInformation("Initiating Edit_User operation at the repository layer: {Operation}.", operation);

            var _params = new ExtendedDynamicParameters(i_User);
            _params.Add("USER_ID", i_User.USER_ID, DbType.Int64, ParameterDirection.InputOutput);
            _params.Add("CREATED_ON", i_User.CREATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);
            _params.Add("UPDATED_ON", i_User.UPDATED_ON, DbType.DateTimeOffset, ParameterDirection.Output);

            await _databaseContext.Execute<User>(Enum_Operation_Type.Execute, "UP_EDIT_USER", _params).ConfigureAwait(false);

            i_User.USER_ID = _params.Get<long>("USER_ID");
            i_User.CREATED_ON = _params.Get<DateTimeOffset>("CREATED_ON");
            i_User.UPDATED_ON = _params.Get<DateTimeOffset>("UPDATED_ON");

            _logger.LogInformation("Edit_User operation at the repository layer completed successfully: {Operation}. User ID: {USER_ID}", operation, i_User.USER_ID);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during {Operation} at the repository layer.", operation);
            throw;
        }
    }
}
