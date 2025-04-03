
using Outstaff_1.Services.Main.DTO;
using Outstaff_1.Services.Main.DTO.GetAllData;

namespace Outstaff_1.Services.Main
{
    public interface IMainService
    {
        Task<IReadOnlyCollection<GetAllDataResultDTO>> GetAllData(GetAllDataFilterDTO getAllDataFilterDto, CancellationToken cancellationToken);
        Task SaveData(IReadOnlyCollection<SaveDataDTO> dto, CancellationToken cancellationToken);
    }
}