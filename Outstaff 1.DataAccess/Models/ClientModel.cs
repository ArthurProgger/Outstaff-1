using Outstaff_1.DataAccess.Models.Interfaces;

namespace Outstaff_1.DataAccess.Models;

public sealed class ClientModel : IEntityId<long>
{
    public long Id { get; set; }
    public string ClientName { get; set; } = null!;
}