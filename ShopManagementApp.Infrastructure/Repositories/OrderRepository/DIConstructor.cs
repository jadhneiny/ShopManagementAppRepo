using Microsoft.Extensions.Logging;
using ShopManagementApp.Infrastructure.Contracts;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class OrderRepository : IOrderRepository
{
    private readonly IDatabaseContext _databaseContext;
    private readonly ILogger<OrderRepository> _logger;

    public OrderRepository(
        ILogger<OrderRepository> i_Logger,
        IDatabaseContext i_DatabaseContext
    )
    {
        _databaseContext = i_DatabaseContext ?? throw new ArgumentNullException(nameof(i_DatabaseContext));
        _logger = i_Logger ?? throw new ArgumentNullException(nameof(i_Logger));
    }
}
