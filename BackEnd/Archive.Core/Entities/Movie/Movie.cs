using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Entities.Movie
{
    public class Movie : IEquatable<Movie?>
    {
        public Guid Id { get; set; }
        public DateOnly Release { get; set; }
        public int Duration { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? OriginalName { get; set; }
        public string? pathToPoster { get; set; }
        public IList<Actor>? Actors { get; set; }
        public IList<Country>? Countries { get; set; }
        public IList<Director>? Directors { get; set; }
        public IList<Genre>? Genres { get; set; }
        public IList<Theme>? Themes { get; set; }
        public IList<Translator>? Translators { get; set; }
        public IList<Type>? Types { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Movie);
        }

        public bool Equals(Movie? other)
        {
            return other is not null &&
                   Id.Equals(other.Id) &&
                   Release.Equals(other.Release) &&
                   Duration == other.Duration &&
                   Description == other.Description &&
                   Name == other.Name &&
                   OriginalName == other.OriginalName &&
                   pathToPoster == other.pathToPoster;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Release, Duration, Description, Name, OriginalName, pathToPoster);
        }

        public static bool operator ==(Movie? left, Movie? right)
        {
            return EqualityComparer<Movie>.Default.Equals(left, right);
        }

        public static bool operator !=(Movie? left, Movie? right)
        {
            return !(left == right);
        }
    }
}
