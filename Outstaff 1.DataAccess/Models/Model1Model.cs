using Outstaff_1.DataAccess.Models.Interfaces;

namespace Outstaff_1.DataAccess.Models;

public sealed class Model1Model : IEntityId<int>
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Код.
    /// </summary>
    public int Code { get; set; }

    /// <summary>
    /// Значение.
    /// </summary>
    public string Value { get; set; } = null!;
}