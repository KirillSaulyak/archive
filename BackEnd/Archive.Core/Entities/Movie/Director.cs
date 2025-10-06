using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Entities.Movie
{
    public class Director : IEquatable<Director?>
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Director);
        }

        public bool Equals(Director? other)
        {
            return other is not null &&
                   Id.Equals(other.Id) &&
                   FullName == other.FullName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FullName);
        }

        public static bool operator ==(Director? left, Director? right)
        {
            return EqualityComparer<Director>.Default.Equals(left, right);
        }

        public static bool operator !=(Director? left, Director? right)
        {
            return !(left == right);
        }
    }
}
