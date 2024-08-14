using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Address;

namespace ShopManagementApp.Application.Services;

public partial class AddressService
{
    public async Task<Addresses> Get_Addresses_By_ADDRESSES_ID_Eager1To1(Params_Get_Addresses_By_ADDRESSES_ID i_Params_Get_Addresses_By_ADDRESSES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_ADDRESSES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID);

            Addresses oAddresses = null;

            oAddresses = await _addressRepository.Get_Addresses_By_ADDRESSES_ID_Eager1To1(i_Params_Get_Addresses_By_ADDRESSES_ID).ConfigureAwait(false);

            if (oAddresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_ADDRESSES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_ADDRESSES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            }

            return oAddresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_ADDRESSES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_ADDRESSES_ID_List_Eager1To1(Params_Get_Addresses_By_ADDRESSES_ID_List i_Params_Get_Addresses_By_ADDRESSES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_ADDRESSES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);

            IEnumerable<Addresses> oList_Addresses = null;

            oList_Addresses = await _addressRepository.Get_Addresses_By_ADDRESSES_ID_List_Eager1To1(i_Params_Get_Addresses_By_ADDRESSES_ID_List).ConfigureAwait(false);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_ADDRESSES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_ADDRESSES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_ADDRESSES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID_Eager1To1(Params_Get_Addresses_By_CUSTOMERS_ID i_Params_Get_Addresses_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID);

            IEnumerable<Addresses> oList_Addresses = null;

            oList_Addresses = await _addressRepository.Get_Addresses_By_CUSTOMERS_ID_Eager1To1(i_Params_Get_Addresses_By_CUSTOMERS_ID).ConfigureAwait(false);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1(Params_Get_Addresses_By_CUSTOMERS_ID_List i_Params_Get_Addresses_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);

            IEnumerable<Addresses> oList_Addresses = null;

            oList_Addresses = await _addressRepository.Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1(i_Params_Get_Addresses_By_CUSTOMERS_ID_List).ConfigureAwait(false);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Get_Addresses_By_Properties_Response> Get_Addresses_By_Properties_Eager1To1(Params_Get_Addresses_By_Properties i_Params_Get_Addresses_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_Properties);

            Get_Addresses_By_Properties_Response oGet_Addresses_By_Properties_Response = null;

            if (i_Params_Get_Addresses_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Addresses_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Addresses_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Addresses_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Addresses_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Addresses_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Addresses_By_Properties.IS_EAGER_LOAD = true;

            oGet_Addresses_By_Properties_Response = await _addressRepository.Get_Addresses_By_Properties_Eager1To1(i_Params_Get_Addresses_By_Properties).ConfigureAwait(false);

            if (oGet_Addresses_By_Properties_Response != null && oGet_Addresses_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Addresses_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Addresses_By_Properties, oGet_Addresses_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_Properties);
            }

            return oGet_Addresses_By_Properties_Response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_TENANT_ID_Eager1To1(Params_Get_Addresses_By_TENANT_ID i_Params_Get_Addresses_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_TENANT_ID);

            IEnumerable<Addresses> oList_Addresses = null;

            oList_Addresses = await _addressRepository.Get_Addresses_By_TENANT_ID_Eager1To1(i_Params_Get_Addresses_By_TENANT_ID).ConfigureAwait(false);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_TENANT_ID);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_TENANT_ID);
            throw;
        }
    }
}
