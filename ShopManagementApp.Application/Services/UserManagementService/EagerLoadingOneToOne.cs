using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.UserManagement;

namespace ShopManagementApp.Application.Services;

public partial class UserManagementService
{
    public async Task<Admins> Get_Admins_By_ADMINS_ID_Eager1To1(Params_Get_Admins_By_ADMINS_ID i_Params_Get_Admins_By_ADMINS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Admins_By_ADMINS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Admins_By_ADMINS_ID);

            Admins oAdmins = null;

            oAdmins = await _userManagementRepository.Get_Admins_By_ADMINS_ID_Eager1To1(i_Params_Get_Admins_By_ADMINS_ID).ConfigureAwait(false);

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

            IEnumerable<Admins> oList_Admins = null;

            oList_Admins = await _userManagementRepository.Get_Admins_By_ADMINS_ID_List_Eager1To1(i_Params_Get_Admins_By_ADMINS_ID_List).ConfigureAwait(false);

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

            Get_Admins_By_Properties_Response oGet_Admins_By_Properties_Response = null;

            if (i_Params_Get_Admins_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Admins_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Admins_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Admins_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Admins_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Admins_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Admins_By_Properties.IS_EAGER_LOAD = true;

            oGet_Admins_By_Properties_Response = await _userManagementRepository.Get_Admins_By_Properties_Eager1To1(i_Params_Get_Admins_By_Properties).ConfigureAwait(false);

            if (oGet_Admins_By_Properties_Response != null && oGet_Admins_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Admins_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Admins_By_Properties, oGet_Admins_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Admins_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Admins_By_Properties);
            }

            return oGet_Admins_By_Properties_Response;
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

            IEnumerable<Admins> oList_Admins = null;

            oList_Admins = await _userManagementRepository.Get_Admins_By_TENANT_ID_Eager1To1(i_Params_Get_Admins_By_TENANT_ID).ConfigureAwait(false);

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

            IEnumerable<Admins> oList_Admins = null;

            oList_Admins = await _userManagementRepository.Get_Admins_By_TENANTS_ID_Eager1To1(i_Params_Get_Admins_By_TENANTS_ID).ConfigureAwait(false);

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

            IEnumerable<Admins> oList_Admins = null;

            oList_Admins = await _userManagementRepository.Get_Admins_By_TENANTS_ID_List_Eager1To1(i_Params_Get_Admins_By_TENANTS_ID_List).ConfigureAwait(false);

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

            Customers oCustomers = null;

            oCustomers = await _userManagementRepository.Get_Customers_By_CUSTOMERS_ID_Eager1To1(i_Params_Get_Customers_By_CUSTOMERS_ID).ConfigureAwait(false);

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

            IEnumerable<Customers> oList_Customers = null;

            oList_Customers = await _userManagementRepository.Get_Customers_By_CUSTOMERS_ID_List_Eager1To1(i_Params_Get_Customers_By_CUSTOMERS_ID_List).ConfigureAwait(false);

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

            Get_Customers_By_Properties_Response oGet_Customers_By_Properties_Response = null;

            if (i_Params_Get_Customers_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Customers_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Customers_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Customers_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Customers_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Customers_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Customers_By_Properties.IS_EAGER_LOAD = true;

            oGet_Customers_By_Properties_Response = await _userManagementRepository.Get_Customers_By_Properties_Eager1To1(i_Params_Get_Customers_By_Properties).ConfigureAwait(false);

            if (oGet_Customers_By_Properties_Response != null && oGet_Customers_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Customers_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Customers_By_Properties, oGet_Customers_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Customers_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Customers_By_Properties);
            }

            return oGet_Customers_By_Properties_Response;
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

            IEnumerable<Customers> oList_Customers = null;

            oList_Customers = await _userManagementRepository.Get_Customers_By_TENANT_ID_Eager1To1(i_Params_Get_Customers_By_TENANT_ID).ConfigureAwait(false);

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

            IEnumerable<Customers> oList_Customers = null;

            oList_Customers = await _userManagementRepository.Get_Customers_By_TENANTS_ID_Eager1To1(i_Params_Get_Customers_By_TENANTS_ID).ConfigureAwait(false);

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

            IEnumerable<Customers> oList_Customers = null;

            oList_Customers = await _userManagementRepository.Get_Customers_By_TENANTS_ID_List_Eager1To1(i_Params_Get_Customers_By_TENANTS_ID_List).ConfigureAwait(false);

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
