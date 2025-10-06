using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Entities.Movie
{
    public class Type
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public IList<Movie>? Movies { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Type);
        }
        public bool Equals(Type? other)
        {
            return other is not null &&
                   Id.Equals(other.Id) &&
                   Name == other.Name;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
        public static bool operator ==(Type? left, Type? right)
        {
            return EqualityComparer<Type>.Default.Equals(left, right);
        }
        public static bool operator !=(Type? left, Type? right)
        {
            return !(left == right);
        }
    }
}
