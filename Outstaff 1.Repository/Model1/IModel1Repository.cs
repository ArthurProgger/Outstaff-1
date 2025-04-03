using Outstaff_1.DataAccess.Models;
using Outstaff_1.Repository.Model1.DTO.GetAllData;

namespace Outstaff_1.Repository.Model1
{
    public interface IModel1Repository
    {
        Task ClearAllData(CancellationToken cancellationToken);
        Task<GetAllDataResultRepositoryDTO[]> GetAllData(GetAllDataFilterRepositoryDTO? getAllDataFilterRepositoryDto, CancellationToken cancellationToken);
        Task SaveData(Model1Model[] data, CancellationToken cancellationToken);
    }
}