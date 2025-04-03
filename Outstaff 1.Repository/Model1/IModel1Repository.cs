using Outstaff_1.DataAccess.Models;
using Outstaff_1.Repository.DTO.GetAllData;

namespace Outstaff_1.Repository.Model1
{
    public interface IModel1Repository
    {
        Task ClearAllData(CancellationToken cancellationToken);
        Task<List<GetAllDataResultRepositoryDTO>> GetAllData(GetAllDataFilterRepositoryDTO getAllDataFilterRepositoryDto, CancellationToken cancellationToken);
        Task SaveData(IReadOnlyCollection<Model1Model> data, CancellationToken cancellationToken);
    }
}