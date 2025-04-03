using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Outstaff_1.Controllers.Main.Requests;
using Outstaff_1.Controllers.Main.Results;
using Outstaff_1.Services.Main;
using Outstaff_1.Services.Main.DTO;
using Outstaff_1.Services.Main.DTO.GetAllData;

namespace Outstaff_1.Controllers.Main;

[Route("api/[controller]")]
[ApiController]
public class MainController(IMainService mainService, IMapper mapper) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<ActionResult> SaveData([FromBody]IReadOnlyCollection<SaveDataRequest> request, CancellationToken cancellationToken)
    {
        var saveDataDto = mapper.From(request).AdaptToType<SaveDataDTO[]>();

        await mainService.SaveData(saveDataDto, cancellationToken);

        return Ok();
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<IReadOnlyCollection<GetAllDataResult>>> GetAllData([FromQuery] GetAllDataRequest request, CancellationToken cancellationToken)
    {
        var getAllDataFilterDto = mapper.From(request).AdaptToType<GetAllDataFilterDTO>();
        var allData = await mainService.GetAllData(getAllDataFilterDto, cancellationToken);
        var result = mapper.From(allData).AdaptToType<GetAllDataResult[]>();

        return Ok(result);
    }
}