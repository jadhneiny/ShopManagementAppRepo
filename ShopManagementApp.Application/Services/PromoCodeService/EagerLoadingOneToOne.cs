using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.PromoCode;

namespace ShopManagementApp.Application.Services;

public partial class PromoCodeService
{
    public async Task<Promo_codes> Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1(Params_Get_Promo_codes_By_PROMO_CODES_ID i_Params_Get_Promo_codes_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Promo_codes_By_PROMO_CODES_ID);

            Promo_codes oPromo_codes = null;

            oPromo_codes = await _promoCodeRepository.Get_Promo_codes_By_PROMO_CODES_ID_Eager1To1(i_Params_Get_Promo_codes_By_PROMO_CODES_ID).ConfigureAwait(false);

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

            IEnumerable<Promo_codes> oList_Promo_codes = null;

            oList_Promo_codes = await _promoCodeRepository.Get_Promo_codes_By_PROMO_CODES_ID_List_Eager1To1(i_Params_Get_Promo_codes_By_PROMO_CODES_ID_List).ConfigureAwait(false);

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

            Get_Promo_codes_By_Properties_Response oGet_Promo_codes_By_Properties_Response = null;

            if (i_Params_Get_Promo_codes_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Promo_codes_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Promo_codes_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Promo_codes_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Promo_codes_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Promo_codes_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Promo_codes_By_Properties.IS_EAGER_LOAD = true;

            oGet_Promo_codes_By_Properties_Response = await _promoCodeRepository.Get_Promo_codes_By_Properties_Eager1To1(i_Params_Get_Promo_codes_By_Properties).ConfigureAwait(false);

            if (oGet_Promo_codes_By_Properties_Response != null && oGet_Promo_codes_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Promo_codes_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Promo_codes_By_Properties, oGet_Promo_codes_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Promo_codes_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Promo_codes_By_Properties);
            }

            return oGet_Promo_codes_By_Properties_Response;
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

            IEnumerable<Promo_codes> oList_Promo_codes = null;

            oList_Promo_codes = await _promoCodeRepository.Get_Promo_codes_By_TENANT_ID_Eager1To1(i_Params_Get_Promo_codes_By_TENANT_ID).ConfigureAwait(false);

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

            IEnumerable<Promo_codes> oList_Promo_codes = null;

            oList_Promo_codes = await _promoCodeRepository.Get_Promo_codes_By_TENANTS_ID_Eager1To1(i_Params_Get_Promo_codes_By_TENANTS_ID).ConfigureAwait(false);

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

            IEnumerable<Promo_codes> oList_Promo_codes = null;

            oList_Promo_codes = await _promoCodeRepository.Get_Promo_codes_By_TENANTS_ID_List_Eager1To1(i_Params_Get_Promo_codes_By_TENANTS_ID_List).ConfigureAwait(false);

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
