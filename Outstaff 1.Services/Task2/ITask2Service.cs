using Outstaff_1.Services.Task2.DTO;

namespace Outstaff_1.Services.Task2
{
    public interface ITask2Service
    {
        Task<GetClientsAndTheirContactsCountsResultDTO[]> GetClientsAndTheirContactsCounts(CancellationToken cancellationToken);
        Task<GetClientsWithMore2ContactsResultDTO[]> GetClientsWithMore2Contacts(CancellationToken cancellationToken);
    }
}