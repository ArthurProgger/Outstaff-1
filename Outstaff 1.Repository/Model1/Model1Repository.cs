using Microsoft.EntityFrameworkCore;
using Outstaff_1.DataAccess;
using Outstaff_1.DataAccess.Models;
using Outstaff_1.Repository.DTO.GetAllData;
using System.Collections.Immutable;

namespace Outstaff_1.Repository.Model1;

public sealed class Model1Repository(DataContext dataContext) : IModel1Repository
{
    public async Task SaveData(IReadOnlyCollection<Model1Model> data, CancellationToken cancellationToken)
    {
        await dataContext.AddRangeAsync(data, cancellationToken);
        await dataContext.SaveChangesAsync(cancellationToken);
    }

    public Task ClearAllData(CancellationToken cancellationToken) =>
        dataContext.Model1Collection.ExecuteDeleteAsync(cancellationToken);

    public Task<List<GetAllDataResultRepositoryDTO>> GetAllData(GetAllDataFilterRepositoryDTO getAllDataFilterRepositoryDto, CancellationToken cancellationToken) =>
        dataContext
        .Model1Collection
        .AsNoTracking()
        .IgnoreAutoIncludes()
        .Where(model => getAllDataFilterRepositoryDto.Id == null || model.Id == getAllDataFilterRepositoryDto.Id)
        .Where(model => getAllDataFilterRepositoryDto.Code == null || model.Code == getAllDataFilterRepositoryDto.Code)
        .Where(model => getAllDataFilterRepositoryDto.Value == null || model.Value == getAllDataFilterRepositoryDto.Value)
        .Select(model => new GetAllDataResultRepositoryDTO(
            model.Id,
            model.Code,
            model.Value))
        .ToListAsync(cancellationToken);
}