namespace Archive.Core.Entities.MovieSpace
{
    public class Movie
    {
        public Guid Id { get; set; }
        public DateOnly? Release { get; set; }
        public int? Duration { get; set; }
        public string? Description { get; set; }
        public required string Name { get; set; }
        public string? OriginalName { get; set; }
        public required string PosterFileExtension { get; set; }
        public IList<Actor> Actors { get; set; } = [];
        public IList<Category> Categories { get; set; } = [];
        public IList<Country> Countries { get; set; } = [];
        public IList<Director> Directors { get; set; } = [];
        public IList<Genre> Genres { get; set; } = [];
        public IList<Theme> Themes { get; set; } = [];
        public IList<Translator> Translators { get; set; } = [];
    }
}
