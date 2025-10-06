using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Entities.Movie
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Genre);
        }
        public bool Equals(Genre? other)
        {
            return other is not null &&
                   Id.Equals(other.Id) &&
                   Name == other.Name;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
        public static bool operator ==(Genre? left, Genre? right)
        {
            return EqualityComparer<Genre>.Default.Equals(left, right);
        }
        public static bool operator !=(Genre? left, Genre? right)
        {
            return !(left == right);
        }
    }
}
