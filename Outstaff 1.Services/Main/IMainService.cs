
using Outstaff_1.Services.Main.DTO;
using Outstaff_1.Services.Main.DTO.GetAllData;

namespace Outstaff_1.Services.Main
{
    public interface IMainService
    {
        Task ClearAllData(CancellationToken cancellationToken);
        Task<GetAllDataResultDTO[]> GetAllData(GetAllDataFilterDTO? getAllDataFilterDto, CancellationToken cancellationToken);
        Task SaveData(SaveDataDTO[] dto, CancellationToken cancellationToken);
    }
}