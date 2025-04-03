using Outstaff_1.DataAccess.Models.Interfaces;

namespace Outstaff_1.DataAccess.Models;

public sealed class ClientContactModel : IEntityId<long>
{
    public long Id { get; set; }
    public long ClientId { get; set; }
    public ClientModel Client { get; set; } = null!;
    public string ContactType { get; set; } = null!;
    public string ContactValue { get; set; } = null!;
}