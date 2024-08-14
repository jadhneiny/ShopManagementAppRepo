using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Business;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class BusinessRepository
{
    public async Task<Get_Setup_By_Properties_Response> Get_Setup_By_Properties_Eager1To1(Params_Get_Setup_By_Properties i_Params_Get_Setup_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int64, direction: ParameterDirection.Output);


            var oList_Setup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SETUP_BY_PROPERTIES",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);
            var oTotalCount = _params.Get<long>("TOTAL_COUNT");

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Setup_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_Properties);
            }

            return new()
            {
                List_Setup = oList_Setup,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_CATEGORY_ID_Eager1To1(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            var oList_Setup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SETUP_BY_SETUP_CATEGORY_ID_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_CATEGORY_ID_List_Eager1To1(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            var oList_Setup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);
            throw;
        }
    }

    public async Task<Setup> Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Eager1To1(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            var oSetup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oSetup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            }

            return oSetup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
            throw;
        }
    }

    public async Task<Setup> Get_Setup_By_SETUP_ID_Eager1To1(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_ID);

            var oSetup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_SETUP_BY_SETUP_ID_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oSetup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_ID);
            }

            return oSetup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_SETUP_ID_List_Eager1To1(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_SETUP_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_SETUP_ID_List);

            var oList_Setup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SETUP_BY_SETUP_ID_LIST_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_SETUP_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_SETUP_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_SETUP_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_SETUP_ID_List);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_SETUP_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_SETUP_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Setup>> Get_Setup_By_TENANT_ID_Eager1To1(Params_Get_Setup_By_TENANT_ID i_Params_Get_Setup_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Setup_By_TENANT_ID);

            var oList_Setup = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_SETUP_BY_TENANT_ID_EAGER1TO1",
                _params,
                "SETUP_CATEGORY_ID",
                [
                    typeof(Setup),
                    typeof(Setup_category)
                ],
                Result =>
                {
                    if (Result[0] is Setup _Setup)
                    {
                        if (Result[1] is Setup_category _Setup_category)
                        {
                            _Setup.Setup_category = _Setup_category;
                        }
                        return _Setup;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Setup != null)
            {
                _logger.LogInformation("Get_Setup_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Setup_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_TENANT_ID);
            }

            return oList_Setup;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Setup_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_TENANT_ID);
            throw;
        }
    }

    public async Task<User> Get_User_By_EMAIL_TENANT_ID_Eager1To1(Params_Get_User_By_EMAIL_TENANT_ID i_Params_Get_User_By_EMAIL_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_EMAIL_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_EMAIL_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_EMAIL_TENANT_ID);

            var oUser = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_USER_BY_EMAIL_TENANT_ID_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_EMAIL_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_EMAIL_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_EMAIL_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_EMAIL_TENANT_ID);
            throw;
        }
    }

    public async Task<Get_User_By_Properties_Response> Get_User_By_Properties_Eager1To1(Params_Get_User_By_Properties i_Params_Get_User_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int64, direction: ParameterDirection.Output);


            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_PROPERTIES",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);
            var oTotalCount = _params.Get<long>("TOTAL_COUNT");

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_User_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_User_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_Properties);
            }

            return new()
            {
                List_User = oList_User,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_TENANT_ID_Eager1To1(Params_Get_User_By_TENANT_ID i_Params_Get_User_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_TENANT_ID);

            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_TENANT_ID_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_TENANT_ID);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_TENANT_ID_IS_DELETED_Eager1To1(Params_Get_User_By_TENANT_ID_IS_DELETED i_Params_Get_User_By_TENANT_ID_IS_DELETED)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_TENANT_ID_IS_DELETED_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_TENANT_ID_IS_DELETED);

            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_TENANT_ID_IS_DELETED_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_TENANT_ID_IS_DELETED_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            }
            else
            {
                _logger.LogWarning("Get_User_By_TENANT_ID_IS_DELETED_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_TENANT_ID_IS_DELETED_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_TENANT_ID_IS_DELETED);
            throw;
        }
    }

    public async Task<User> Get_User_By_USER_ID_Eager1To1(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_ID);

            var oUser = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_USER_BY_USER_ID_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_USER_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_ID_List_Eager1To1(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_ID_List);

            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_USER_ID_LIST_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_ID_List);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_TYPE_SETUP_ID_Eager1To1(Params_Get_User_By_USER_TYPE_SETUP_ID i_Params_Get_User_By_USER_TYPE_SETUP_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_TYPE_SETUP_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_TYPE_SETUP_ID);

            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_USER_TYPE_SETUP_ID_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_TYPE_SETUP_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_TYPE_SETUP_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_TYPE_SETUP_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID);
            throw;
        }
    }

    public async Task<IEnumerable<User>> Get_User_By_USER_TYPE_SETUP_ID_List_Eager1To1(Params_Get_User_By_USER_TYPE_SETUP_ID_List i_Params_Get_User_By_USER_TYPE_SETUP_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USER_TYPE_SETUP_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

            var oList_User = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_USER_BY_USER_TYPE_SETUP_ID_LIST_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_User != null)
            {
                _logger.LogInformation("Get_User_By_USER_TYPE_SETUP_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USER_TYPE_SETUP_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            }

            return oList_User;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USER_TYPE_SETUP_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);
            throw;
        }
    }

    public async Task<User> Get_User_By_USERNAME_TENANT_ID_Eager1To1(Params_Get_User_By_USERNAME_TENANT_ID i_Params_Get_User_By_USERNAME_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_User_By_USERNAME_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USERNAME_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_User_By_USERNAME_TENANT_ID);

            var oUser = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_USER_BY_USERNAME_TENANT_ID_EAGER1TO1",
                _params,
                "SETUP_ID",
                [
                    typeof(User),
                    typeof(Setup)
                ],
                Result =>
                {
                    if (Result[0] is User _User)
                    {
                        if (Result[1] is Setup _User_type_setup)
                        {
                            _User.User_type_setup = _User_type_setup;
                        }
                        return _User;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oUser != null)
            {
                _logger.LogInformation("Get_User_By_USERNAME_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_User_By_USERNAME_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            }

            return oUser;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_User_By_USERNAME_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_User_By_USERNAME_TENANT_ID);
            throw;
        }
    }
}
