using Microsoft.EntityFrameworkCore;
using Outstaff_1.DataAccess;
using Outstaff_1.Repository.Client;
using Outstaff_1.Repository.Model1;

namespace Outstaff_1.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder AddRepositories(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DataBase");
        builder.Services.AddMySql<DataContext>(connectionString, ServerVersion.AutoDetect(connectionString));

        builder.Services.AddScoped<IModel1Repository, Model1Repository>();
        builder.Services.AddScoped<IClientRepository, ClientRepository>();

        return builder;
    }
}