using Microsoft.Extensions.Logging;
using ShopManagementApp.Infrastructure.Contracts;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class UserManagementRepository : IUserManagementRepository
{
    private readonly IDatabaseContext _databaseContext;
    private readonly ILogger<UserManagementRepository> _logger;

    public UserManagementRepository(
        ILogger<UserManagementRepository> i_Logger,
        IDatabaseContext i_DatabaseContext
    )
    {
        _databaseContext = i_DatabaseContext ?? throw new ArgumentNullException(nameof(i_DatabaseContext));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
    }
}
