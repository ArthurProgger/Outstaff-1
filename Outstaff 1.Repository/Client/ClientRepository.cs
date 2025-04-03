using Microsoft.EntityFrameworkCore;
using Outstaff_1.DataAccess;
using Outstaff_1.DataAccess.Models;
using Outstaff_1.Repository.Client.DTO;

namespace Outstaff_1.Repository.Client;

public sealed class ClientRepository(DataContext dataContext) : IClientRepository
{
    public Task<GetClientsAndTheirContactsCountsResultRepositoryDTO[]> GetClientsAndTheirContactsCounts(CancellationToken cancellationToken) =>
        dataContext
            .Clients
            .GroupJoin(
                dataContext.ClientContacts,
                client => client.Id,
                contact => contact.ClientId,
                (client, contacts) => new { client, contacts }
            )
            .Select(result => new GetClientsAndTheirContactsCountsResultRepositoryDTO(
                result.client.ClientName,
                result.contacts.Count()
            ))
            .ToArrayAsync(cancellationToken);

    public Task<ClientModel[]> GetClientsWithMore2Contacts(CancellationToken cancellationToken) =>
        dataContext
        .ClientContacts
        .GroupBy(contact => contact.Client)
        .Where(group => group.Count() > 2)
        .Select(group => group.Key)
        .ToArrayAsync(cancellationToken);
}