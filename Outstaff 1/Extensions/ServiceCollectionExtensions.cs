using Outstaff_1.Services.Main;
using Outstaff_1.Services.Task2;

namespace Outstaff_1.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCustomServices(this IServiceCollection service)
    {
        service.AddScoped<IMainService, MainService>();
        service.AddScoped<ITask2Service, Task2Service>();

        return service;
    }
}