namespace Archive.Core.Entities.MovieSpace
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public IList<Movie>? Movies { get; set; }
    }
}
