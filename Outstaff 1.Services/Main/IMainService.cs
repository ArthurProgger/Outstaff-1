
using Outstaff_1.Services.Main.DTO;

namespace Outstaff_1.Services.Main
{
    public interface IMainService
    {
        Task ClearAllData(CancellationToken cancellationToken);
        Task SaveData(SaveDataDTO[] dto, CancellationToken cancellationToken);
    }
}