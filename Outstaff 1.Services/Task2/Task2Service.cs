using Mapster;
using Outstaff_1.Repository.Client;
using Outstaff_1.Services.Task2.DTO;

namespace Outstaff_1.Services.Task2;

public sealed class Task2Service(IClientRepository clientRepository) : ITask2Service
{
    public async Task<GetClientsAndTheirContactsCountsResultDTO[]> GetClientsAndTheirContactsCounts(CancellationToken cancellationToken)
    {
        var data = await clientRepository.GetClientsAndTheirContactsCounts(cancellationToken);
        var result = data.Adapt<GetClientsAndTheirContactsCountsResultDTO[]>();

        return result;
    }

    public async Task<GetClientsWithMore2ContactsResultDTO[]> GetClientsWithMore2Contacts(CancellationToken cancellationToken)
    {
        var data = await clientRepository.GetClientsWithMore2Contacts(cancellationToken);
        var result = data.Adapt<GetClientsWithMore2ContactsResultDTO[]>();

        return result;
    }
}