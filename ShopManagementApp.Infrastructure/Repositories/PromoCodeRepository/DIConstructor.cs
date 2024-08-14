using Microsoft.Extensions.Logging;
using ShopManagementApp.Infrastructure.Contracts;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class PromoCodeRepository : IPromoCodeRepository
{
    private readonly IDatabaseContext _databaseContext;
    private readonly ILogger<PromoCodeRepository> _logger;

    public PromoCodeRepository(
        ILogger<PromoCodeRepository> i_Logger,
        IDatabaseContext i_DatabaseContext
    )
    {
        _databaseContext = i_DatabaseContext ?? throw new ArgumentNullException(nameof(i_DatabaseContext));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
    }
}
