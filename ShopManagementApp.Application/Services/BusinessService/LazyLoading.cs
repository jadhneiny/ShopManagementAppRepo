using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Business;

namespace ShopManagementApp.Application.Services;

public partial class BusinessService
{
    public async Task<Get_Setup_By_Properties_Response> Get_Setup_By_Properties(Params_Get_Setup_By_Properties i_Params_Get_Setup_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Setup_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Setup_By_Properties);

            Get_Setup_By_Properties_Response oGet_Setup_By_Properties_Response = null;

            if (i_Params_Get_Setup_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Setup_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Setup_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Setup_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Setup_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Setup_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Setup_By_Properties.IS_EAGER_LOAD = false;

            oGet_Setup_By_Properties_Response = await _businessRepository.Get_Setup_By_Properties(i_Params_Get_Setup_By_Properties).ConfigureAwait(false);

            if (oGet_Setup_By_Properties_Response != null && oGet_Setup_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Setup_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Setup_By_Properties, oGet_Setup_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Setup_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_By_Properties);
            }

            return oGet_Setup_By_Properties_Response;
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

            IEnumerable<Setup> oList_Setup = null;

            oList_Setup = await _businessRepository.Get_Setup_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_By_SETUP_CATEGORY_ID).ConfigureAwait(false);

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

            IEnumerable<Setup> oList_Setup = null;

            oList_Setup = await _businessRepository.Get_Setup_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List).ConfigureAwait(false);

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

            Setup oSetup = null;

            oSetup = await _businessRepository.Get_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE).ConfigureAwait(false);

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

            Setup oSetup = null;

            oSetup = await _businessRepository.Get_Setup_By_SETUP_ID(i_Params_Get_Setup_By_SETUP_ID).ConfigureAwait(false);

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

            IEnumerable<Setup> oList_Setup = null;

            oList_Setup = await _businessRepository.Get_Setup_By_SETUP_ID_List(i_Params_Get_Setup_By_SETUP_ID_List).ConfigureAwait(false);

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

            IEnumerable<Setup> oList_Setup = null;

            oList_Setup = await _businessRepository.Get_Setup_By_TENANT_ID(i_Params_Get_Setup_By_TENANT_ID).ConfigureAwait(false);

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

            Get_Setup_category_By_Properties_Response oGet_Setup_category_By_Properties_Response = null;

            if (i_Params_Get_Setup_category_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Setup_category_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Setup_category_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Setup_category_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Setup_category_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Setup_category_By_Properties.FETCH_NEXT = 1000000;
            }

            oGet_Setup_category_By_Properties_Response = await _businessRepository.Get_Setup_category_By_Properties(i_Params_Get_Setup_category_By_Properties).ConfigureAwait(false);

            if (oGet_Setup_category_By_Properties_Response != null && oGet_Setup_category_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Setup_category_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Setup_category_By_Properties, oGet_Setup_category_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Setup_category_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Setup_category_By_Properties);
            }

            return oGet_Setup_category_By_Properties_Response;
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

            Setup_category oSetup_category = null;

            oSetup_category = await _businessRepository.Get_Setup_category_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID).ConfigureAwait(false);

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

            IEnumerable<Setup_category> oList_Setup_category = null;

            oList_Setup_category = await _businessRepository.Get_Setup_category_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List).ConfigureAwait(false);

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

            IEnumerable<Setup_category> oList_Setup_category = null;

            oList_Setup_category = await _businessRepository.Get_Setup_category_By_TENANT_ID(i_Params_Get_Setup_category_By_TENANT_ID).ConfigureAwait(false);

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

            IEnumerable<Tenant> oList_Tenant = null;

            oList_Tenant = await _businessRepository.Get_Tenant_By_IS_DELETED(i_Params_Get_Tenant_By_IS_DELETED).ConfigureAwait(false);

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

            Get_Tenant_By_Properties_Response oGet_Tenant_By_Properties_Response = null;

            if (i_Params_Get_Tenant_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Tenant_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Tenant_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Tenant_By_Properties.FETCH_NEXT = 1000000;
            }

            oGet_Tenant_By_Properties_Response = await _businessRepository.Get_Tenant_By_Properties(i_Params_Get_Tenant_By_Properties).ConfigureAwait(false);

            if (oGet_Tenant_By_Properties_Response != null && oGet_Tenant_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Tenant_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Tenant_By_Properties, oGet_Tenant_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Tenant_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Tenant_By_Properties);
            }

            return oGet_Tenant_By_Properties_Response;
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

            Tenant oTenant = null;

            oTenant = await _businessRepository.Get_Tenant_By_TENANT_ID(i_Params_Get_Tenant_By_TENANT_ID).ConfigureAwait(false);

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

            IEnumerable<Tenant> oList_Tenant = null;

            oList_Tenant = await _businessRepository.Get_Tenant_By_TENANT_ID_List(i_Params_Get_Tenant_By_TENANT_ID_List).ConfigureAwait(false);

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

            User oUser = null;

            oUser = await _businessRepository.Get_User_By_EMAIL_TENANT_ID(i_Params_Get_User_By_EMAIL_TENANT_ID).ConfigureAwait(false);

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

            Get_User_By_Properties_Response oGet_User_By_Properties_Response = null;

            if (i_Params_Get_User_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_User_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_User_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_User_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_User_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_User_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_User_By_Properties.IS_EAGER_LOAD = false;

            oGet_User_By_Properties_Response = await _businessRepository.Get_User_By_Properties(i_Params_Get_User_By_Properties).ConfigureAwait(false);

            if (oGet_User_By_Properties_Response != null && oGet_User_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_User_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_User_By_Properties, oGet_User_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_User_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_User_By_Properties);
            }

            return oGet_User_By_Properties_Response;
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

            IEnumerable<User> oList_User = null;

            oList_User = await _businessRepository.Get_User_By_TENANT_ID(i_Params_Get_User_By_TENANT_ID).ConfigureAwait(false);

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

            IEnumerable<User> oList_User = null;

            oList_User = await _businessRepository.Get_User_By_TENANT_ID_IS_DELETED(i_Params_Get_User_By_TENANT_ID_IS_DELETED).ConfigureAwait(false);

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

            User oUser = null;

            oUser = await _businessRepository.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID).ConfigureAwait(false);

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

            IEnumerable<User> oList_User = null;

            oList_User = await _businessRepository.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List).ConfigureAwait(false);

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

            IEnumerable<User> oList_User = null;

            oList_User = await _businessRepository.Get_User_By_USER_TYPE_SETUP_ID(i_Params_Get_User_By_USER_TYPE_SETUP_ID).ConfigureAwait(false);

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

            IEnumerable<User> oList_User = null;

            oList_User = await _businessRepository.Get_User_By_USER_TYPE_SETUP_ID_List(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List).ConfigureAwait(false);

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

            User oUser = null;

            oUser = await _businessRepository.Get_User_By_USERNAME_TENANT_ID(i_Params_Get_User_By_USERNAME_TENANT_ID).ConfigureAwait(false);

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
