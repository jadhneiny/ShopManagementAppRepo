using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Product;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class ProductRepository
{
    public async Task<Products> Get_Products_By_PRODUCTS_ID(Params_Get_Products_By_PRODUCTS_ID i_Params_Get_Products_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Products_By_PRODUCTS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Products_By_PRODUCTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_PRODUCTS_ID);
            var oProducts = await _databaseContext.Execute<Products>(Enum_Operation_Type.QuerySingle, "UP_GET_PRODUCTS_BY_PRODUCTS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_PRODUCTS_ID_List);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_PRODUCTS_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_PROPERTIES", _params).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Products != null)
            {
                _logger.LogInformation("Get_Products_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Products_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Products_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Products_By_Properties);
            }

            return new()
            {
                List_Products = oList_Products,
                TOTAL_COUNT = oTotalCount
            };
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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_SHOPS_ID);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_SHOPS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_SHOPS_ID_List);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_SHOPS_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_TENANT_ID);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_TENANT_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_TENANTS_ID);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_TENANTS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Products_By_TENANTS_ID_List);
            var oList_Products = await _databaseContext.Execute<Products>(Enum_Operation_Type.Query, "UP_GET_PRODUCTS_BY_TENANTS_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Shops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.Query, "UP_GET_SHOPS_BY_PROPERTIES", _params).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Shops != null)
            {
                _logger.LogInformation("Get_Shops_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Shops_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Shops_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Shops_By_Properties);
            }

            return new()
            {
                List_Shops = oList_Shops,
                TOTAL_COUNT = oTotalCount
            };
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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_SHOPS_ID);
            var oShops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.QuerySingle, "UP_GET_SHOPS_BY_SHOPS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_SHOPS_ID_List);
            var oList_Shops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.Query, "UP_GET_SHOPS_BY_SHOPS_ID_LIST", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_TENANT_ID);
            var oList_Shops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.Query, "UP_GET_SHOPS_BY_TENANT_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_TENANTS_ID);
            var oList_Shops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.Query, "UP_GET_SHOPS_BY_TENANTS_ID", _params).ConfigureAwait(false);

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

            var _params = new ExtendedDynamicParameters(i_Params_Get_Shops_By_TENANTS_ID_List);
            var oList_Shops = await _databaseContext.Execute<Shops>(Enum_Operation_Type.Query, "UP_GET_SHOPS_BY_TENANTS_ID_LIST", _params).ConfigureAwait(false);

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
