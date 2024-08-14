using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.UserManagement;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class UserManagementRepository
{
    public async Task<Admins> Get_Admins_By_ADMINS_ID_Eager1To1(Params_Get_Admins_By_ADMINS_ID i_Params_Get_Admins_By_ADMINS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_ADMINS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_ADMINS_ID);

            var oAdmins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_ADMINS_BY_ADMINS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oAdmins != null)
            {
                _logger.LogInformation("Get_Admins_By_ADMINS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_ADMINS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_ADMINS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_ADMINS_ID);
            }

            return oAdmins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_ADMINS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_ADMINS_ID_List_Eager1To1(Params_Get_Admins_By_ADMINS_ID_List i_Params_Get_Admins_By_ADMINS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_ADMINS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_ADMINS_ID_List);

            var oList_Admins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADMINS_BY_ADMINS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_ADMINS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_ADMINS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_ADMINS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_ADMINS_ID_List);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_ADMINS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID_List);
            throw;
        }
    }

    public async Task<Get_Admins_By_Properties_Response> Get_Admins_By_Properties_Eager1To1(Params_Get_Admins_By_Properties i_Params_Get_Admins_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Admins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADMINS_BY_PROPERTIES",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Admins_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_Properties);
            }

            return new()
            {
                List_Admins = oList_Admins,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_TENANT_ID_Eager1To1(Params_Get_Admins_By_TENANT_ID i_Params_Get_Admins_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_TENANT_ID);

            var oList_Admins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADMINS_BY_TENANT_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_TENANT_ID);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_TENANTS_ID_Eager1To1(Params_Get_Admins_By_TENANTS_ID i_Params_Get_Admins_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_TENANTS_ID);

            var oList_Admins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADMINS_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_TENANTS_ID);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Admins>> Get_Admins_By_TENANTS_ID_List_Eager1To1(Params_Get_Admins_By_TENANTS_ID_List i_Params_Get_Admins_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Admins_By_TENANTS_ID_List);

            var oList_Admins = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ADMINS_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Admins),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Admins _Admins)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Admins.Tenants = _Tenants;
                        }
                        return _Admins;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Admins != null)
            {
                _logger.LogInformation("Get_Admins_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Admins_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_TENANTS_ID_List);
            }

            return oList_Admins;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Admins_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Customers> Get_Customers_By_CUSTOMERS_ID_Eager1To1(Params_Get_Customers_By_CUSTOMERS_ID i_Params_Get_Customers_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_CUSTOMERS_ID);

            var oCustomers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_CUSTOMERS_BY_CUSTOMERS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oCustomers != null)
            {
                _logger.LogInformation("Get_Customers_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID);
            }

            return oCustomers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_CUSTOMERS_ID_List_Eager1To1(Params_Get_Customers_By_CUSTOMERS_ID_List i_Params_Get_Customers_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_CUSTOMERS_ID_List);

            var oList_Customers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_CUSTOMERS_BY_CUSTOMERS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Get_Customers_By_Properties_Response> Get_Customers_By_Properties_Eager1To1(Params_Get_Customers_By_Properties i_Params_Get_Customers_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Customers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_CUSTOMERS_BY_PROPERTIES",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Customers_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_Properties);
            }

            return new()
            {
                List_Customers = oList_Customers,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_TENANT_ID_Eager1To1(Params_Get_Customers_By_TENANT_ID i_Params_Get_Customers_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_TENANT_ID);

            var oList_Customers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_CUSTOMERS_BY_TENANT_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_TENANT_ID);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_TENANTS_ID_Eager1To1(Params_Get_Customers_By_TENANTS_ID i_Params_Get_Customers_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_TENANTS_ID);

            var oList_Customers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_CUSTOMERS_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_TENANTS_ID);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Customers>> Get_Customers_By_TENANTS_ID_List_Eager1To1(Params_Get_Customers_By_TENANTS_ID_List i_Params_Get_Customers_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Customers_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Customers_By_TENANTS_ID_List);

            var oList_Customers = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_CUSTOMERS_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Customers),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Customers _Customers)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Customers.Tenants = _Tenants;
                        }
                        return _Customers;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Customers != null)
            {
                _logger.LogInformation("Get_Customers_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Customers_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_TENANTS_ID_List);
            }

            return oList_Customers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Customers_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Customers_By_TENANTS_ID_List);
            throw;
        }
    }
}
