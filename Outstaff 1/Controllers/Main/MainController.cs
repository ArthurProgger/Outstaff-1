using Mapster;
using Microsoft.AspNetCore.Mvc;
using Outstaff_1.Controllers.Main.Requests;
using Outstaff_1.Controllers.Main.Results;
using Outstaff_1.Services.Main;
using Outstaff_1.Services.Main.DTO;
using Outstaff_1.Services.Main.DTO.GetAllData;

namespace Outstaff_1.Controllers.Main;

[Route("api/[controller]")]
[ApiController]
public class MainController(IMainService mainService) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<ActionResult> SaveData([FromBody]SaveDataRequest[] request, CancellationToken cancellationToken)
    {
        var dto = request.Adapt<SaveDataDTO[]>();

        await mainService.ClearAllData(cancellationToken);
        await mainService.SaveData(dto, cancellationToken);

        return Ok();
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<GetAllDataResult[]>> GetAllData([FromQuery] GetAllDataRequest request, CancellationToken cancellationToken)
    {
        var getAllDataFilterDto = request.Adapt<GetAllDataFilterDTO>();
        var allData = await mainService.GetAllData(getAllDataFilterDto, cancellationToken);
        var result = allData.Adapt<GetAllDataResult[]>();

        return Ok(result);
    }
}