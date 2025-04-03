using MapsterMapper;
using Outstaff_1.DataAccess.Models;
using Outstaff_1.Repository.DTO.GetAllData;
using Outstaff_1.Repository.Model1;
using Outstaff_1.Services.Main.DTO;
using Outstaff_1.Services.Main.DTO.GetAllData;

namespace Outstaff_1.Services.Main;

public sealed class MainService(IModel1Repository model1Repository, IMapper mapper) : IMainService
{
    public async Task SaveData(IReadOnlyCollection<SaveDataDTO> saveDataDto, CancellationToken cancellationToken)
    {
        var models = mapper.From(saveDataDto.OrderBy(data => data.Code)).AdaptToType<Model1Model[]>();

        await model1Repository.ClearAllData(cancellationToken);
        await model1Repository.SaveData(models, cancellationToken);
    }

    public async Task<IReadOnlyCollection<GetAllDataResultDTO>> GetAllData(GetAllDataFilterDTO getAllDataFilterDto, CancellationToken cancellationToken)
    {
        var getAllDataFilterRepositoryDto = mapper.From(getAllDataFilterDto).AdaptToType<GetAllDataFilterRepositoryDTO>();
        var dataFromRepository = await model1Repository.GetAllData(getAllDataFilterRepositoryDto, cancellationToken);
        var result = mapper.From(dataFromRepository).AdaptToType<GetAllDataResultDTO[]>();

        return result;
    }
}