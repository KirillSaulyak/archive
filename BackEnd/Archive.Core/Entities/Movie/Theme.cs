using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Entities.Movie
{
    public class Theme
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Theme);
        }
        public bool Equals(Theme? other)
        {
            return other is not null &&
                   Id.Equals(other.Id) &&
                   Name == other.Name;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
        public static bool operator ==(Theme? left, Theme? right)
        {
            return EqualityComparer<Theme>.Default.Equals(left, right);
        }
        public static bool operator !=(Theme? left, Theme? right)
        {
            return !(left == right);
        }
    }
}
