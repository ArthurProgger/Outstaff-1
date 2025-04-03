namespace Outstaff_1.DataAccess.Models.Interfaces;

public interface IEntityId<TId>
{
    TId Id { get; set; }
}