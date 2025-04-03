using Mapster;
using Microsoft.AspNetCore.Mvc;
using Outstaff_1.Controllers.Task2.Response;
using Outstaff_1.Services.Task2;

namespace Outstaff_1.Controllers.Task2;

[Route("api/[controller]")]
[ApiController]
public class Task2Controller(ITask2Service task2Service) : ControllerBase
{
    [HttpGet("[action]")]
    public async Task<ActionResult<GetClientsAndTheirContactsCountsResponse[]>> GetClientsAndTheirContactsCounts(CancellationToken cancellationToken)
    {
        var data = await task2Service.GetClientsAndTheirContactsCounts(cancellationToken);
        var response = data.Adapt<GetClientsAndTheirContactsCountsResponse[]>();

        return Ok(response);
    }

    [HttpGet("[action]")]
    public async Task<ActionResult<GetClientsWithMore2ContactsResponse[]>> GetClientsWithMore2Contacts(CancellationToken cancellationToken)
    {
        var data = await task2Service.GetClientsWithMore2Contacts(cancellationToken);
        var response = data.Adapt<GetClientsWithMore2ContactsResponse[]>();

        return Ok(response);
    }
}