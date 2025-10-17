namespace Archive.Core.Entities.Movies
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public IList<Movie>? Movies { get; set; }
    }
}