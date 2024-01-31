namespace Core.Persistence.Repositories;

public class BaseEntity<TId> : IEntityTimestamps
{
    public BaseEntity()
    {
        Id = default;
    }

    public BaseEntity(TId id)
    {
        Id = id;
    }

    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}