using System.ComponentModel.DataAnnotations;

namespace Archive.Core.Entities.Movie
{
    public class Actor : IEquatable<Actor?>
    { 
        public Guid Id { get; set; }

        public string? FullName { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Actor);
        }

        public bool Equals(Actor? other)
        {
            return other is not null &&
                   Id.Equals(other.Id) &&
                   FullName == other.FullName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FullName);
        }

        public static bool operator ==(Actor? left, Actor? right)
        {
            return EqualityComparer<Actor>.Default.Equals(left, right);
        }

        public static bool operator !=(Actor? left, Actor? right)
        {
            return !(left == right);
        }
    }
}