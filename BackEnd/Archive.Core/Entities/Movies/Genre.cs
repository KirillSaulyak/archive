namespace Archive.Core.Entities.Movies
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public IList<Movie>? Movies { get; set; }
    }
}
