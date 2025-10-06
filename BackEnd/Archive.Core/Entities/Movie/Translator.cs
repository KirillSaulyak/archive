using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Entities.Movie
{
    public class Translator : IEquatable<Translator?>
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Translator);
        }

        public bool Equals(Translator? other)
        {
            return other is not null &&
                   Id.Equals(other.Id) &&
                   FullName == other.FullName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FullName);
        }

        public static bool operator ==(Translator? left, Translator? right)
        {
            return EqualityComparer<Translator>.Default.Equals(left, right);
        }

        public static bool operator !=(Translator? left, Translator? right)
        {
            return !(left == right);
        }
    }
}
