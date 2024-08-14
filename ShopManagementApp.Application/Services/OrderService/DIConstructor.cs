using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ShopManagementApp.Application.Contracts;
using ShopManagementApp.Common.Contracts;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Infrastructure.Contracts;

namespace ShopManagementApp.Application.Services;

public partial class OrderService : IOrderService
{
    private readonly ApplicationSettings _applicationSettings;
    private readonly ILogger<OrderService> _logger;
    private readonly IDatabaseContext _databaseContext;
    private readonly IUserSessionContext _userSessionContext;
    private readonly ICommonService _commonService;
    private readonly IProductService _productService;
    private readonly IUserManagementService _userManagementService;
    private readonly IOrderRepository _orderRepository;

    public OrderService(
        IOptions<ApplicationSettings> i_ApplicationSettings,
        ILogger<OrderService> i_Logger,
        IDatabaseContext i_DatabaseContext,
        IUserSessionContext i_UserSessionContext,
        ICommonService i_CommonService,
        IProductService i_ProductService,
        IUserManagementService i_UserManagementService,
        IOrderRepository i_OrderRepository
    )
    {
        _applicationSettings = i_ApplicationSettings?.Value ?? throw new ArgumentNullException(nameof(i_ApplicationSettings));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
        _databaseContext = i_DatabaseContext ?? throw new ArgumentNullException(nameof(i_DatabaseContext));
        _userSessionContext = i_UserSessionContext ?? throw new ArgumentNullException(nameof(i_UserSessionContext));
        _commonService = i_CommonService ?? throw new ArgumentNullException(nameof(i_CommonService));
        _productService = i_ProductService ?? throw new ArgumentNullException(nameof(i_ProductService));
        _userManagementService = i_UserManagementService ?? throw new ArgumentNullException(nameof(i_UserManagementService));
        _orderRepository = i_OrderRepository ?? throw new ArgumentNullException(nameof(i_OrderRepository));

        PostConstruct();
    }
}
