using Outstaff_1.DataAccess.Models.Interfaces;

namespace Outstaff_1.DataAccess.Models;

public sealed class Model1Model : IEntityId<int>
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Value { get; set; } = null!;
}