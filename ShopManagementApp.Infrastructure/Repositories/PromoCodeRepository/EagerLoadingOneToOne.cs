using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.PromoCode;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class PromoCodeRepository
{
    public async Task<Promo_codes> Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1(Params_Get_Promo_codes_By_PROMO_CODES_ID i_Params_Get_Promo_codes_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_PROMO_CODES_ID);

            var oPromo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_PROMO_CODES_BY_PROMO_CODES_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oPromo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
            }

            return oPromo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1(Params_Get_Promo_codes_By_PROMO_CODES_ID_List i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);

            var oList_Promo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PROMO_CODES_BY_PROMO_CODES_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List);
            throw;
        }
    }

    public async Task<Get_Promo_codes_By_Properties_Response> Get_Promo_codes_By_Properties_Eager1To1(Params_Get_Promo_codes_By_Properties i_Params_Get_Promo_codes_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Promo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PROMO_CODES_BY_PROPERTIES",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Promo_codes_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_Properties);
            }

            return new()
            {
                List_Promo_codes = oList_Promo_codes,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANT_ID_Eager1To1(Params_Get_Promo_codes_By_TENANT_ID i_Params_Get_Promo_codes_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_TENANT_ID);

            var oList_Promo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PROMO_CODES_BY_TENANT_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_TENANT_ID);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANTS_ID_Eager1To1(Params_Get_Promo_codes_By_TENANTS_ID i_Params_Get_Promo_codes_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_TENANTS_ID);

            var oList_Promo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PROMO_CODES_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Promo_codes>> Get_Promo_codes_By_TENANTS_ID_List_Eager1To1(Params_Get_Promo_codes_By_TENANTS_ID_List i_Params_Get_Promo_codes_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Promo_codes_By_TENANTS_ID_List);

            var oList_Promo_codes = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_PROMO_CODES_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "TENANTS_ID",
                [
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Promo_codes _Promo_codes)
                    {
                        if (Result[1] is Tenants _Tenants)
                        {
                            _Promo_codes.Tenants = _Tenants;
                        }
                        return _Promo_codes;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Promo_codes != null)
            {
                _logger.LogInformation("Get_Promo_codes_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);
            }

            return oList_Promo_codes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Promo_codes_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_TENANTS_ID_List);
            throw;
        }
    }
}
