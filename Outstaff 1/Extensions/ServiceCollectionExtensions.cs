using Outstaff_1.Services.Main;

namespace Outstaff_1.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection service)
    {
        service.AddScoped<IMainService, MainService>();

        return service;
    }
}