using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Common;

namespace ShopManagementApp.Application.Services;

public partial class CommonService
{
    public async Task<Get_Tenants_By_Properties_Response> Get_Tenants_By_Properties(Params_Get_Tenants_By_Properties i_Params_Get_Tenants_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenants_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_Properties);

            Get_Tenants_By_Properties_Response oGet_Tenants_By_Properties_Response = null;

            if (i_Params_Get_Tenants_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Tenants_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Tenants_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Tenants_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Tenants_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Tenants_By_Properties.FETCH_NEXT = 1000000;
            }

            oGet_Tenants_By_Properties_Response = await _commonRepository.Get_Tenants_By_Properties(i_Params_Get_Tenants_By_Properties).ConfigureAwait(false);

            if (oGet_Tenants_By_Properties_Response != null && oGet_Tenants_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Tenants_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Tenants_By_Properties, oGet_Tenants_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Tenants_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenants_By_Properties);
            }

            return oGet_Tenants_By_Properties_Response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenants_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Tenants>> Get_Tenants_By_TENANT_ID(Params_Get_Tenants_By_TENANT_ID i_Params_Get_Tenants_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenants_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANT_ID);

            IEnumerable<Tenants> oList_Tenants = null;

            oList_Tenants = await _commonRepository.Get_Tenants_By_TENANT_ID(i_Params_Get_Tenants_By_TENANT_ID).ConfigureAwait(false);

            if (oList_Tenants != null)
            {
                _logger.LogInformation("Get_Tenants_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenants_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Tenants_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenants_By_TENANT_ID);
            }

            return oList_Tenants;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenants_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANT_ID);
            throw;
        }
    }

    public async Task<Tenants> Get_Tenants_By_TENANTS_ID(Params_Get_Tenants_By_TENANTS_ID i_Params_Get_Tenants_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenants_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANTS_ID);

            Tenants oTenants = null;

            oTenants = await _commonRepository.Get_Tenants_By_TENANTS_ID(i_Params_Get_Tenants_By_TENANTS_ID).ConfigureAwait(false);

            if (oTenants != null)
            {
                _logger.LogInformation("Get_Tenants_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenants_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Tenants_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenants_By_TENANTS_ID);
            }

            return oTenants;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenants_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Tenants>> Get_Tenants_By_TENANTS_ID_List(Params_Get_Tenants_By_TENANTS_ID_List i_Params_Get_Tenants_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Tenants_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANTS_ID_List);

            IEnumerable<Tenants> oList_Tenants = null;

            oList_Tenants = await _commonRepository.Get_Tenants_By_TENANTS_ID_List(i_Params_Get_Tenants_By_TENANTS_ID_List).ConfigureAwait(false);

            if (oList_Tenants != null)
            {
                _logger.LogInformation("Get_Tenants_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Tenants_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Tenants_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenants_By_TENANTS_ID_List);
            }

            return oList_Tenants;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Tenants_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Tenants_By_TENANTS_ID_List);
            throw;
        }
    }
}
