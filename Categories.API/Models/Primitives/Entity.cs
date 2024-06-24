namespace Categories.API.Models.Primitives;

public class Entity : IEquatable<Entity>
{
    public Guid Id { get; set; }

    public Entity(Guid id)
    {
        Id = id;
    }

    public bool Equals(Entity? other)
    {
        if (other is null)
            return false;

        return Id.Equals(other.Id);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Entity other)
        {
            return false;
        }

        return Equals(other);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
