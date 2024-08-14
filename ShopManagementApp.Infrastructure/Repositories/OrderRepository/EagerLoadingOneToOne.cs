using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Order;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Domain.Product;
using ShopManagementApp.Domain.PromoCode;
using ShopManagementApp.Domain.UserManagement;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class OrderRepository
{
    public async Task<Order_details> Get_Order_details_By_ORDER_DETAILS_ID_Eager1To1(Params_Get_Order_details_By_ORDER_DETAILS_ID i_Params_Get_Order_details_By_ORDER_DETAILS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDER_DETAILS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDER_DETAILS_ID);

            var oOrder_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oOrder_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDER_DETAILS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDER_DETAILS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            }

            return oOrder_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDER_DETAILS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDER_DETAILS_ID_List_Eager1To1(Params_Get_Order_details_By_ORDER_DETAILS_ID_List i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDER_DETAILS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_ORDER_DETAILS_ID_LIST_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDER_DETAILS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDER_DETAILS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDER_DETAILS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID_Eager1To1(Params_Get_Order_details_By_ORDERS_ID i_Params_Get_Order_details_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDERS_ID);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_ORDERS_ID_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDERS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID_List_Eager1To1(Params_Get_Order_details_By_ORDERS_ID_List i_Params_Get_Order_details_By_ORDERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_ORDERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_ORDERS_ID_List);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_ORDERS_ID_LIST_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_ORDERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_ORDERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_ORDERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_ORDERS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID_Eager1To1(Params_Get_Order_details_By_PRODUCTS_ID i_Params_Get_Order_details_By_PRODUCTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_PRODUCTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_PRODUCTS_ID);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_PRODUCTS_ID_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_PRODUCTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_PRODUCTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_PRODUCTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID_List_Eager1To1(Params_Get_Order_details_By_PRODUCTS_ID_List i_Params_Get_Order_details_By_PRODUCTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_PRODUCTS_ID_List);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_PRODUCTS_ID_LIST_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_PRODUCTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_PRODUCTS_ID_List);
            throw;
        }
    }

    public async Task<Get_Order_details_By_Properties_Response> Get_Order_details_By_Properties_Eager1To1(Params_Get_Order_details_By_Properties i_Params_Get_Order_details_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_PROPERTIES",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Order_details_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_Properties);
            }

            return new()
            {
                List_Order_details = oList_Order_details,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANT_ID_Eager1To1(Params_Get_Order_details_By_TENANT_ID i_Params_Get_Order_details_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANT_ID);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_TENANT_ID_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANT_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID_Eager1To1(Params_Get_Order_details_By_TENANTS_ID i_Params_Get_Order_details_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANTS_ID);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANTS_ID);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID_List_Eager1To1(Params_Get_Order_details_By_TENANTS_ID_List i_Params_Get_Order_details_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Order_details_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Order_details_By_TENANTS_ID_List);

            var oList_Order_details = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDER_DETAILS_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "ORDERS_ID, PRODUCTS_ID, TENANTS_ID",
                [
                    typeof(Order_details),
                    typeof(Orders),
                    typeof(Products),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Order_details _Order_details)
                    {
                        if (Result[1] is Orders _Orders && _Order_details.ORDERS_ID != null)
                        {
                            _Order_details.Orders = _Orders;
                        }
                        if (Result[2] is Products _Products && _Order_details.PRODUCTS_ID != null)
                        {
                            _Order_details.Products = _Products;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Order_details.Tenants = _Tenants;
                        }
                        return _Order_details;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Order_details != null)
            {
                _logger.LogInformation("Get_Order_details_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Order_details_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            }

            return oList_Order_details;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Order_details_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Order_details_By_TENANTS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID_Eager1To1(Params_Get_Orders_By_CUSTOMERS_ID i_Params_Get_Orders_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_CUSTOMERS_ID);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_CUSTOMERS_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_CUSTOMERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID_List_Eager1To1(Params_Get_Orders_By_CUSTOMERS_ID_List i_Params_Get_Orders_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_CUSTOMERS_ID_List);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_CUSTOMERS_ID_LIST_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_CUSTOMERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Orders> Get_Orders_By_ORDERS_ID_Eager1To1(Params_Get_Orders_By_ORDERS_ID i_Params_Get_Orders_By_ORDERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_ORDERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_ORDERS_ID);

            var oOrders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerlySingle,
                "UP_GET_ORDERS_BY_ORDERS_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oOrders != null)
            {
                _logger.LogInformation("Get_Orders_By_ORDERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_ORDERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_ORDERS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_ORDERS_ID);
            }

            return oOrders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_ORDERS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_ORDERS_ID_List_Eager1To1(Params_Get_Orders_By_ORDERS_ID_List i_Params_Get_Orders_By_ORDERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_ORDERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_ORDERS_ID_List);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_ORDERS_ID_LIST_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_ORDERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_ORDERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_ORDERS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_ORDERS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_ORDERS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_ORDERS_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID_Eager1To1(Params_Get_Orders_By_PROMO_CODES_ID i_Params_Get_Orders_By_PROMO_CODES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_PROMO_CODES_ID);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_PROMO_CODES_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_PROMO_CODES_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID_List_Eager1To1(Params_Get_Orders_By_PROMO_CODES_ID_List i_Params_Get_Orders_By_PROMO_CODES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_PROMO_CODES_ID_List);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_PROMO_CODES_ID_LIST_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_PROMO_CODES_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_PROMO_CODES_ID_List);
            throw;
        }
    }

    public async Task<Get_Orders_By_Properties_Response> Get_Orders_By_Properties_Eager1To1(Params_Get_Orders_By_Properties i_Params_Get_Orders_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);


            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_PROPERTIES",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Orders_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_Properties_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_Properties);
            }

            return new()
            {
                List_Orders = oList_Orders,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_Properties_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANT_ID_Eager1To1(Params_Get_Orders_By_TENANT_ID i_Params_Get_Orders_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANT_ID);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_TENANT_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANT_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANT_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANT_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANT_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID_Eager1To1(Params_Get_Orders_By_TENANTS_ID i_Params_Get_Orders_By_TENANTS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANTS_ID);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_TENANTS_ID_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANTS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANTS_ID_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANTS_ID);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANTS_ID_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID_List_Eager1To1(Params_Get_Orders_By_TENANTS_ID_List i_Params_Get_Orders_By_TENANTS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Orders_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Orders_By_TENANTS_ID_List);

            var oList_Orders = await _databaseContext.Execute
            (
                Enum_Operation_Type.QueryEagerly,
                "UP_GET_ORDERS_BY_TENANTS_ID_LIST_EAGER1TO1",
                _params,
                "CUSTOMERS_ID, PROMO_CODES_ID, TENANTS_ID",
                [
                    typeof(Orders),
                    typeof(Customers),
                    typeof(Promo_codes),
                    typeof(Tenants)
                ],
                Result =>
                {
                    if (Result[0] is Orders _Orders)
                    {
                        if (Result[1] is Customers _Customers && _Orders.CUSTOMERS_ID != null)
                        {
                            _Orders.Customers = _Customers;
                        }
                        if (Result[2] is Promo_codes _Promo_codes && _Orders.PROMO_CODES_ID != null)
                        {
                            _Orders.Promo_codes = _Promo_codes;
                        }
                        if (Result[3] is Tenants _Tenants)
                        {
                            _Orders.Tenants = _Tenants;
                        }
                        return _Orders;
                    }
                    else
                    {
                        return null;
                    }
                }
            ).ConfigureAwait(false);

            if (oList_Orders != null)
            {
                _logger.LogInformation("Get_Orders_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Orders_By_TENANTS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Orders_By_TENANTS_ID_List_Eager1To1 operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Orders_By_TENANTS_ID_List);
            }

            return oList_Orders;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Orders_By_TENANTS_ID_List_Eager1To1 operation at the repository layer with parameters: {@Params}.", i_Params_Get_Orders_By_TENANTS_ID_List);
            throw;
        }
    }
}
