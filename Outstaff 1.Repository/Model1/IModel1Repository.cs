using Outstaff_1.DataAccess.Models;

namespace Outstaff_1.Repository.Model1
{
    public interface IModel1Repository
    {
        Task ClearAllData(CancellationToken cancellationToken);
        Task SaveData(Model1Model[] data, CancellationToken cancellationToken);
    }
}