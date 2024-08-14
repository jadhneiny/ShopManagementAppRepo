using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Business;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class BusinessRepository
{
    public async Task<Get_Setup_By_Properties_Response> Get_Setup_By_Properties(Params_Get_Setup_By_Properties i_Params_Get_Setup_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int64, direction: ParameterDirection.Output);

            var oList_Setup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.Query, "UP_GET_SETUP_BY_PROPERTIES", _params).ConfigureAwait(false);
            var oTotalCount = _params.Get<long>("TOTAL_COUNT");

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Setup_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_Properties);
            }

            return new()
            {
                List_Setup = oList_Setup,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_CATEGORY_ID(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            var oList_Setup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.Query, "UP_GET_SETUP_BY_SETUP_CATEGORY_ID", _params).ConfigureAwait(false);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            var oList_Setup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.Query, "UP_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST", _params).ConfigureAwait(false);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            throw;
        }
    }

    public async Task<Setup> Get_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            var oSetup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.QuerySingle, "UP_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params).ConfigureAwait(false);

            if (oSetup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            }

            return oSetup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID_VALUE operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            throw;
        }
    }

    public async Task<Setup> Get_Setup_By_SETUP_ID(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_ID);
            var oSetup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.QuerySingle, "UP_GET_SETUP_BY_SETUP_ID", _params).ConfigureAwait(false);

            if (oSetup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_ID);
            }

            return oSetup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_ID_List(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_ID_List);
            var oList_Setup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.Query, "UP_GET_SETUP_BY_SETUP_ID_LIST", _params).ConfigureAwait(false);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_ID_List);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_TENANT_ID(Params_Get_Setup_By_TENANT_ID i_Params_Get_Setup_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_TENANT_ID);
            var oList_Setup = await _databaseContext.Execute<Setup>(Enum_Operation_Type.Query, "UP_GET_SETUP_BY_TENANT_ID", _params).ConfigureAwait(false);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_TENANT_ID);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_TENANT_ID);
            throw;
        }
    }

    public async Task<Get_Setup_category_By_Properties_Response> Get_Setup_category_By_Properties(Params_Get_Setup_category_By_Properties i_Params_Get_Setup_category_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_category_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_category_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Setup_category = await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Query, "UP_GET_SETUP_CATEGORY_BY_PROPERTIES", _params).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Setup_category != null)
            {
                _logger.LogInformation("Get_Setup_category_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Setup_category_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Setup_category_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_category_By_Properties);
            }

            return new()
            {
                List_Setup_category = oList_Setup_category,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_category_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_Properties);
            throw;
        }
    }

    public async Task<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_category_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);
            var oSetup_category = await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.QuerySingle, "UP_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID", _params).ConfigureAwait(false);

            if (oSetup_category != null)
            {
                _logger.LogInformation("Get_Setup_category_By_SETUP_CATEGORY_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_category_By_SETUP_CATEGORY_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);
            }

            return oSetup_category;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_category_By_SETUP_CATEGORY_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Setup_category>> Get_Setup_category_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_category_By_SETUP_CATEGORY_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);
            var oList_Setup_category = await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Query, "UP_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID_LIST", _params).ConfigureAwait(false);

            if (oList_Setup_category != null)
            {
                _logger.LogInformation("Get_Setup_category_By_SETUP_CATEGORY_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Setup_category_By_SETUP_CATEGORY_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);
            }

            return oList_Setup_category;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_category_By_SETUP_CATEGORY_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Setup_category>> Get_Setup_category_By_TENANT_ID(Params_Get_Setup_category_By_TENANT_ID i_Params_Get_Setup_category_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_category_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_category_By_TENANT_ID);
            var oList_Setup_category = await _databaseContext.Execute<Setup_category>(Enum_Operation_Type.Query, "UP_GET_SETUP_CATEGORY_BY_TENANT_ID", _params).ConfigureAwait(false);

            if (oList_Setup_category != null)
            {
                _logger.LogInformation("Get_Setup_category_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_category_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_category_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_category_By_TENANT_ID);
            }

            return oList_Setup_category;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_category_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_category_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Tenant>> Get_Tenant_By_IS_DELETED(Params_Get_Tenant_By_IS_DELETED i_Params_Get_Tenant_By_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenant_By_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_IS_DELETED);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenant_By_IS_DELETED);
            var oList_Tenant = await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Query, "UP_GET_TENANT_BY_IS_DELETED", _params).ConfigureAwait(false);

            if (oList_Tenant != null)
            {
                _logger.LogInformation("Get_Tenant_By_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenant_By_IS_DELETED);
            }
            else
            {
                _logger.LogWarning("Get_Tenant_By_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenant_By_IS_DELETED);
            }

            return oList_Tenant;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenant_By_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_IS_DELETED);
            throw;
        }
    }

    public async Task<Get_Tenant_By_Properties_Response> Get_Tenant_By_Properties(Params_Get_Tenant_By_Properties i_Params_Get_Tenant_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenant_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenant_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Tenant = await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Query, "UP_GET_TENANT_BY_PROPERTIES", _params).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Tenant != null)
            {
                _logger.LogInformation("Get_Tenant_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Tenant_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Tenant_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenant_By_Properties);
            }

            return new()
            {
                List_Tenant = oList_Tenant,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenant_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_Properties);
            throw;
        }
    }

    public async Task<Tenant> Get_Tenant_By_TENANT_ID(Params_Get_Tenant_By_TENANT_ID i_Params_Get_Tenant_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenant_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenant_By_TENANT_ID);
            var oTenant = await _databaseContext.Execute<Tenant>(Enum_Operation_Type.QuerySingle, "UP_GET_TENANT_BY_TENANT_ID", _params).ConfigureAwait(false);

            if (oTenant != null)
            {
                _logger.LogInformation("Get_Tenant_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenant_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Tenant_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenant_By_TENANT_ID);
            }

            return oTenant;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenant_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Tenant>> Get_Tenant_By_TENANT_ID_List(Params_Get_Tenant_By_TENANT_ID_List i_Params_Get_Tenant_By_TENANT_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenant_By_TENANT_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_TENANT_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Tenant_By_TENANT_ID_List);
            var oList_Tenant = await _databaseContext.Execute<Tenant>(Enum_Operation_Type.Query, "UP_GET_TENANT_BY_TENANT_ID_LIST", _params).ConfigureAwait(false);

            if (oList_Tenant != null)
            {
                _logger.LogInformation("Get_Tenant_By_TENANT_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenant_By_TENANT_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Tenant_By_TENANT_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenant_By_TENANT_ID_List);
            }

            return oList_Tenant;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenant_By_TENANT_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenant_By_TENANT_ID_List);
            throw;
        }
    }

    public async Task<User> Get_User_By_EMAIL_TENANT_ID(Params_Get_User_By_EMAIL_TENANT_ID i_Params_Get_User_By_EMAIL_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_EMAIL_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_EMAIL_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_EMAIL_TENANT_ID);
            var oUser = await _databaseContext.Execute<User>(Enum_Operation_Type.QuerySingle, "UP_GET_USER_BY_EMAIL_TENANT_ID", _params).ConfigureAwait(false);

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_EMAIL_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_EMAIL_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_EMAIL_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            throw;
        }
    }

    public async Task<Get_User_By_Properties_Response> Get_User_By_Properties(Params_Get_User_By_Properties i_Params_Get_User_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int64, direction: ParameterDirection.Output);

            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_PROPERTIES", _params).ConfigureAwait(false);
            var oTotalCount = _params.Get<long>("TOTAL_COUNT");

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_User_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_User_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_Properties);
            }

            return new()
            {
                List_User = oList_User,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_TENANT_ID(Params_Get_User_By_TENANT_ID i_Params_Get_User_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_TENANT_ID);
            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_TENANT_ID", _params).ConfigureAwait(false);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_TENANT_ID);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_TENANT_ID_IS_DELETED(Params_Get_User_By_TENANT_ID_IS_DELETED i_Params_Get_User_By_TENANT_ID_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_TENANT_ID_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_TENANT_ID_IS_DELETED", _params).ConfigureAwait(false);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_TENANT_ID_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            }
            else
            {
                _logger.LogWarning("Get_User_By_TENANT_ID_IS_DELETED operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_TENANT_ID_IS_DELETED operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            throw;
        }
    }

    public async Task<User> Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_ID);
            var oUser = await _databaseContext.Execute<User>(Enum_Operation_Type.QuerySingle, "UP_GET_USER_BY_USER_ID", _params).ConfigureAwait(false);

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_USER_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_ID_List);
            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_USER_ID_LIST", _params).ConfigureAwait(false);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_ID_List);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_TYPE_SETUP_ID(Params_Get_User_By_USER_TYPE_SETUP_ID i_Params_Get_User_By_USER_TYPE_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_TYPE_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_USER_TYPE_SETUP_ID", _params).ConfigureAwait(false);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_TYPE_SETUP_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_TYPE_SETUP_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_TYPE_SETUP_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_TYPE_SETUP_ID_List(Params_Get_User_By_USER_TYPE_SETUP_ID_List i_Params_Get_User_By_USER_TYPE_SETUP_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_TYPE_SETUP_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            var oList_User = await _databaseContext.Execute<User>(Enum_Operation_Type.Query, "UP_GET_USER_BY_USER_TYPE_SETUP_ID_LIST", _params).ConfigureAwait(false);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_TYPE_SETUP_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_TYPE_SETUP_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_TYPE_SETUP_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            throw;
        }
    }

    public async Task<User> Get_User_By_USERNAME_TENANT_ID(Params_Get_User_By_USERNAME_TENANT_ID i_Params_Get_User_By_USERNAME_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USERNAME_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USERNAME_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USERNAME_TENANT_ID);
            var oUser = await _databaseContext.Execute<User>(Enum_Operation_Type.QuerySingle, "UP_GET_USER_BY_USERNAME_TENANT_ID", _params).ConfigureAwait(false);

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_USERNAME_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USERNAME_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USERNAME_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            throw;
        }
    }
}
