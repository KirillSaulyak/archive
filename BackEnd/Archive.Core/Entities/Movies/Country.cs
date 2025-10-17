namespace Archive.Core.Entities.Movies
{
    public class Country
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public IList<Movie>? Movies { get; set; }
    }
}
