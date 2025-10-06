using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Entities.Movie
{
    public class Country : IEquatable<Country?>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Country);
        }

        public bool Equals(Country? other)
        {
            return other is not null &&
                   Id.Equals(other.Id) &&
                   Name == other.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }

        public static bool operator ==(Country? left, Country? right)
        {
            return EqualityComparer<Country>.Default.Equals(left, right);
        }

        public static bool operator !=(Country? left, Country? right)
        {
            return !(left == right);
        }
    }
}
