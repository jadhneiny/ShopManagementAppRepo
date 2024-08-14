using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Product;

namespace ShopManagementApp.Application.Services;

public partial class ProductService
{
    public async Task<Products> Get_Products_By_PRODUCTS_ID(Params_Get_Products_By_PRODUCTS_ID i_Params_Get_Products_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID);

            Products oProducts = null;

            oProducts = await _productRepository.Get_Products_By_PRODUCTS_ID(i_Params_Get_Products_By_PRODUCTS_ID).ConfigureAwait(false);

            if (oProducts != null)
            {
                _logger.LogInformation("Get_Products_By_PRODUCTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_PRODUCTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_PRODUCTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_PRODUCTS_ID);
            }

            return oProducts;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_PRODUCTS_ID_List(Params_Get_Products_By_PRODUCTS_ID_List i_Params_Get_Products_By_PRODUCTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_PRODUCTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID_List);

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _productRepository.Get_Products_By_PRODUCTS_ID_List(i_Params_Get_Products_By_PRODUCTS_ID_List).ConfigureAwait(false);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_PRODUCTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_PRODUCTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_PRODUCTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_PRODUCTS_ID_List);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_PRODUCTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID_List);
            throw;
        }
    }

    public async Task<Get_Products_By_Properties_Response> Get_Products_By_Properties(Params_Get_Products_By_Properties i_Params_Get_Products_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_Properties);

            Get_Products_By_Properties_Response oGet_Products_By_Properties_Response = null;

            if (i_Params_Get_Products_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Products_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Products_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Products_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Products_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Products_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Products_By_Properties.IS_EAGER_LOAD = false;

            oGet_Products_By_Properties_Response = await _productRepository.Get_Products_By_Properties(i_Params_Get_Products_By_Properties).ConfigureAwait(false);

            if (oGet_Products_By_Properties_Response != null && oGet_Products_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Products_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Products_By_Properties, oGet_Products_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_Properties);
            }

            return oGet_Products_By_Properties_Response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_SHOPS_ID(Params_Get_Products_By_SHOPS_ID i_Params_Get_Products_By_SHOPS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID);

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _productRepository.Get_Products_By_SHOPS_ID(i_Params_Get_Products_By_SHOPS_ID).ConfigureAwait(false);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_SHOPS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_SHOPS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_SHOPS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_SHOPS_ID);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_SHOPS_ID_List(Params_Get_Products_By_SHOPS_ID_List i_Params_Get_Products_By_SHOPS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_SHOPS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID_List);

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _productRepository.Get_Products_By_SHOPS_ID_List(i_Params_Get_Products_By_SHOPS_ID_List).ConfigureAwait(false);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_SHOPS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_SHOPS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_SHOPS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_SHOPS_ID_List);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_SHOPS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_SHOPS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_TENANT_ID(Params_Get_Products_By_TENANT_ID i_Params_Get_Products_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANT_ID);

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _productRepository.Get_Products_By_TENANT_ID(i_Params_Get_Products_By_TENANT_ID).ConfigureAwait(false);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_TENANT_ID);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_TENANTS_ID(Params_Get_Products_By_TENANTS_ID i_Params_Get_Products_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID);

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _productRepository.Get_Products_By_TENANTS_ID(i_Params_Get_Products_By_TENANTS_ID).ConfigureAwait(false);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_TENANTS_ID);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Products>> Get_Products_By_TENANTS_ID_List(Params_Get_Products_By_TENANTS_ID_List i_Params_Get_Products_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID_List);

            IEnumerable<Products> oList_Products = null;

            oList_Products = await _productRepository.Get_Products_By_TENANTS_ID_List(i_Params_Get_Products_By_TENANTS_ID_List).ConfigureAwait(false);

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Products_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_TENANTS_ID_List);
            }

            return oList_Products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Products_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<Get_Shops_By_Properties_Response> Get_Shops_By_Properties(Params_Get_Shops_By_Properties i_Params_Get_Shops_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_Properties);

            Get_Shops_By_Properties_Response oGet_Shops_By_Properties_Response = null;

            if (i_Params_Get_Shops_By_Properties.TENANT_ID <= 0)
            {
                i_Params_Get_Shops_By_Properties.TENANT_ID = _userSessionContext.Tenant_ID;
            }
            if (i_Params_Get_Shops_By_Properties.OFFSET is null or < 0)
            {
                i_Params_Get_Shops_By_Properties.OFFSET = 0;
            }
            if (i_Params_Get_Shops_By_Properties.FETCH_NEXT is null or <= 0)
            {
                i_Params_Get_Shops_By_Properties.FETCH_NEXT = 1000000;
            }
            i_Params_Get_Shops_By_Properties.IS_EAGER_LOAD = false;

            oGet_Shops_By_Properties_Response = await _productRepository.Get_Shops_By_Properties(i_Params_Get_Shops_By_Properties).ConfigureAwait(false);

            if (oGet_Shops_By_Properties_Response != null && oGet_Shops_By_Properties_Response.TOTAL_COUNT > 0)
            {
                _logger.LogInformation("Get_Shops_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Shops_By_Properties, oGet_Shops_By_Properties_Response.TOTAL_COUNT);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_Properties);
            }

            return oGet_Shops_By_Properties_Response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_Properties);
            throw;
        }
    }

    public async Task<Shops> Get_Shops_By_SHOPS_ID(Params_Get_Shops_By_SHOPS_ID i_Params_Get_Shops_By_SHOPS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID);

            Shops oShops = null;

            oShops = await _productRepository.Get_Shops_By_SHOPS_ID(i_Params_Get_Shops_By_SHOPS_ID).ConfigureAwait(false);

            if (oShops != null)
            {
                _logger.LogInformation("Get_Shops_By_SHOPS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_SHOPS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_SHOPS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_SHOPS_ID);
            }

            return oShops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_SHOPS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_SHOPS_ID_List(Params_Get_Shops_By_SHOPS_ID_List i_Params_Get_Shops_By_SHOPS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_SHOPS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID_List);

            IEnumerable<Shops> oList_Shops = null;

            oList_Shops = await _productRepository.Get_Shops_By_SHOPS_ID_List(i_Params_Get_Shops_By_SHOPS_ID_List).ConfigureAwait(false);

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_SHOPS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_SHOPS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_SHOPS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_SHOPS_ID_List);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_SHOPS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_SHOPS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_TENANT_ID(Params_Get_Shops_By_TENANT_ID i_Params_Get_Shops_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANT_ID);

            IEnumerable<Shops> oList_Shops = null;

            oList_Shops = await _productRepository.Get_Shops_By_TENANT_ID(i_Params_Get_Shops_By_TENANT_ID).ConfigureAwait(false);

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_TENANT_ID);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_TENANTS_ID(Params_Get_Shops_By_TENANTS_ID i_Params_Get_Shops_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID);

            IEnumerable<Shops> oList_Shops = null;

            oList_Shops = await _productRepository.Get_Shops_By_TENANTS_ID(i_Params_Get_Shops_By_TENANTS_ID).ConfigureAwait(false);

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_TENANTS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_TENANTS_ID);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_TENANTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Shops>> Get_Shops_By_TENANTS_ID_List(Params_Get_Shops_By_TENANTS_ID_List i_Params_Get_Shops_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Shops_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID_List);

            IEnumerable<Shops> oList_Shops = null;

            oList_Shops = await _productRepository.Get_Shops_By_TENANTS_ID_List(i_Params_Get_Shops_By_TENANTS_ID_List).ConfigureAwait(false);

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Shops_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_TENANTS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_TENANTS_ID_List);
            }

            return oList_Shops;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Shops_By_TENANTS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Shops_By_TENANTS_ID_List);
            throw;
        }
    }
}
