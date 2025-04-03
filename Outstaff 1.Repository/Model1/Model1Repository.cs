using Microsoft.EntityFrameworkCore;
using Outstaff_1.DataAccess;
using Outstaff_1.DataAccess.Models;

namespace Outstaff_1.Repository.Model1;

public sealed class Model1Repository(DataContext dataContext) : IModel1Repository
{
    private const string TableName = "Model1Collection";

    public async Task SaveData(Model1Model[] data, CancellationToken cancellationToken)
    {
        await dataContext.AddRangeAsync(data, cancellationToken);
        await dataContext.SaveChangesAsync(cancellationToken);
    }

    public Task ClearAllData(CancellationToken cancellationToken) =>
        dataContext.Database.ExecuteSqlRawAsync($"TRUNCATE TABLE {TableName}", cancellationToken);
}