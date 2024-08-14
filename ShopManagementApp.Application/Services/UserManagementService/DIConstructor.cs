using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ShopManagementApp.Application.Contracts;
using ShopManagementApp.Common.Contracts;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Infrastructure.Contracts;

namespace ShopManagementApp.Application.Services;

public partial class UserManagementService : IUserManagementService
{
    private readonly ApplicationSettings _applicationSettings;
    private readonly ILogger<UserManagementService> _logger;
    private readonly IDatabaseContext _databaseContext;
    private readonly IUserSessionContext _userSessionContext;
    private readonly ICommonService _commonService;
    private readonly IUserManagementRepository _userManagementRepository;

    public UserManagementService(
        IOptions<ApplicationSettings> i_ApplicationSettings,
        ILogger<UserManagementService> i_Logger,
        IDatabaseContext i_DatabaseContext,
        IUserSessionContext i_UserSessionContext,
        ICommonService i_CommonService,
        IUserManagementRepository i_UserManagementRepository
    )
    {
        _applicationSettings = i_ApplicationSettings?.Value ?? throw new ArgumentNullException(nameof(i_ApplicationSettings));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
        _databaseContext = i_DatabaseContext ?? throw new ArgumentNullException(nameof(i_DatabaseContext));
        _userSessionContext = i_UserSessionContext ?? throw new ArgumentNullException(nameof(i_UserSessionContext));
        _commonService = i_CommonService ?? throw new ArgumentNullException(nameof(i_CommonService));
        _userManagementRepository = i_UserManagementRepository ?? throw new ArgumentNullException(nameof(i_UserManagementRepository));

        PostConstruct();
    }
}
