using Serilog;
using ShopManagementApp.Application.Contracts;
using ShopManagementApp.Application.Services;
using ShopManagementApp.Common.Contracts;
using ShopManagementApp.Common.Services;
using ShopManagementApp.Common.UserSession;
using ShopManagementApp.CrossCuttingConcerns.Logging;
using ShopManagementApp.Domain.Common;
using ShopManagementApp.Infrastructure.Contracts;
using ShopManagementApp.Infrastructure.Data;
using ShopManagementApp.Infrastructure.Repositories;
using ShopManagementApp.WebApi.Filters;

namespace ShopManagementApp.WebApi.Configuration;

public static partial class ServiceConfiguration
{
    public static IServiceCollection AddServices(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddScoped<IMessageService, MessageService>();
        services.Configure<ApplicationSettings>(builder.Configuration);
        services.AddSingleton<SerilogConfiguration>();
        if (builder.Configuration["Logging:LogLevel:Default"] != "None")
        {
            builder.Host.UseSerilog((context, config) =>
            {
                var serilogConfig = builder.Services.BuildServiceProvider().GetService<SerilogConfiguration>();
                serilogConfig?.Configure(context, config);
            });
        }
        services.AddScoped<IDatabaseContext, DatabaseContext>();
        services.AddScoped<IUserSessionContext, UserSessionContext>();

        services.AddScoped<IAddressService, AddressService>();
        services.AddTransient<IAddressRepository, AddressRepository>();

        services.AddScoped<ICommonService, CommonService>();
        services.AddTransient<ICommonRepository, CommonRepository>();

        services.AddScoped<IOrderService, OrderService>();
        services.AddTransient<IOrderRepository, OrderRepository>();

        services.AddScoped<IProductService, ProductService>();
        services.AddTransient<IProductRepository, ProductRepository>();

        services.AddScoped<IPromoCodeService, PromoCodeService>();
        services.AddTransient<IPromoCodeRepository, PromoCodeRepository>();

        services.AddScoped<IUserManagementService, UserManagementService>();
        services.AddTransient<IUserManagementRepository, UserManagementRepository>();

        services.AddScoped<IBusinessService, BusinessService>();
        services.AddTransient<IBusinessRepository, BusinessRepository>();

        services.AddControllers(options =>
        {
            options.Filters.Add<ContextResolverFilter>();
        });

        return services;
    }
}
