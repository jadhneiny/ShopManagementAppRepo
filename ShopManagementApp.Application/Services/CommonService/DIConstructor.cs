using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ShopManagementApp.Application.Contracts;
using ShopManagementApp.Common.Contracts;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Infrastructure.Contracts;

namespace ShopManagementApp.Application.Services;

public partial class CommonService : ICommonService
{
    private readonly ApplicationSettings _applicationSettings;
    private readonly ILogger<CommonService> _logger;
    private readonly IDatabaseContext _databaseContext;
    private readonly IUserSessionContext _userSessionContext;
    private readonly ICommonRepository _commonRepository;

    public CommonService(
        IOptions<ApplicationSettings> i_ApplicationSettings,
        ILogger<CommonService> i_Logger,
        IDatabaseContext i_DatabaseContext,
        IUserSessionContext i_UserSessionContext,
        ICommonRepository i_CommonRepository
    )
    {
        _applicationSettings = i_ApplicationSettings?.Value ?? throw new ArgumentNullException(nameof(i_ApplicationSettings));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
        _databaseContext = i_DatabaseContext ?? throw new ArgumentNullException(nameof(i_DatabaseContext));
        _userSessionContext = i_UserSessionContext ?? throw new ArgumentNullException(nameof(i_UserSessionContext));
        _commonRepository = i_CommonRepository ?? throw new ArgumentNullException(nameof(i_CommonRepository));

        PostConstruct();
    }
}
