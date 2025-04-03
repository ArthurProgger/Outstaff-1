using Mapster;
using Outstaff_1.DataAccess.Models;
using Outstaff_1.Repository.Model1;
using Outstaff_1.Services.Main.DTO;

namespace Outstaff_1.Services.Main;

public sealed class MainService(IModel1Repository model1Repository) : IMainService
{
    public Task SaveData(SaveDataDTO[] dto, CancellationToken cancellationToken)
    {
        var models = dto.Adapt<Model1Model[]>();
        return model1Repository.SaveData(models, cancellationToken);
    }

    public Task ClearAllData(CancellationToken cancellationToken) =>
        model1Repository.ClearAllData(cancellationToken);
}