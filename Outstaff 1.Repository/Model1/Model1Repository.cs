using Microsoft.EntityFrameworkCore;
using Outstaff_1.DataAccess;
using Outstaff_1.DataAccess.Models;
using Outstaff_1.Repository.DTO.GetAllData;
using System.Reflection.Metadata;

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

    public Task<GetAllDataResultRepositoryDTO[]> GetAllData(GetAllDataFilterRepositoryDTO? getAllDataFilterRepositoryDto, CancellationToken cancellationToken) =>
        dataContext
        .Model1Collection
        .AsNoTracking()
        .IgnoreAutoIncludes()
        .Where(model => getAllDataFilterRepositoryDto == null ||
            model.Id == getAllDataFilterRepositoryDto.Id ||
            model.Code == getAllDataFilterRepositoryDto.Code ||
            model.Value == getAllDataFilterRepositoryDto.Value)
        .Select(model => new GetAllDataResultRepositoryDTO(
            model.Id,
            model.Code,
            model.Value))
        .ToArrayAsync(cancellationToken);
}