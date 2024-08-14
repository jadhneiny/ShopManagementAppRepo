using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ShopManagementApp.Application.Contracts;
using ShopManagementApp.Common.Contracts;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Infrastructure.Contracts;

namespace ShopManagementApp.Application.Services;

public partial class ProductService : IProductService
{
    private readonly ApplicationSettings _applicationSettings;
    private readonly ILogger<ProductService> _logger;
    private readonly IDatabaseContext _databaseContext;
    private readonly IUserSessionContext _userSessionContext;
    private readonly ICommonService _commonService;
    private readonly IProductRepository _productRepository;

    public ProductService(
        IOptions<ApplicationSettings> i_ApplicationSettings,
        ILogger<ProductService> i_Logger,
        IDatabaseContext i_DatabaseContext,
        IUserSessionContext i_UserSessionContext,
        ICommonService i_CommonService,
        IProductRepository i_ProductRepository
    )
    {
        _applicationSettings = i_ApplicationSettings?.Value ?? throw new ArgumentNullException(nameof(i_ApplicationSettings));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
        _databaseContext = i_DatabaseContext ?? throw new ArgumentNullException(nameof(i_DatabaseContext));
        _userSessionContext = i_UserSessionContext ?? throw new ArgumentNullException(nameof(i_UserSessionContext));
        _commonService = i_CommonService ?? throw new ArgumentNullException(nameof(i_CommonService));
        _productRepository = i_ProductRepository ?? throw new ArgumentNullException(nameof(i_ProductRepository));

        PostConstruct();
    }
}
