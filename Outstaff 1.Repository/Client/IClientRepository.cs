using Outstaff_1.DataAccess.Models;
using Outstaff_1.Repository.Client.DTO;

namespace Outstaff_1.Repository.Client
{
    public interface IClientRepository
    {
        Task<GetClientsAndTheirContactsCountsResultRepositoryDTO[]> GetClientsAndTheirContactsCounts(CancellationToken cancellationToken);
        Task<ClientModel[]> GetClientsWithMore2Contacts(CancellationToken cancellationToken);
    }
}