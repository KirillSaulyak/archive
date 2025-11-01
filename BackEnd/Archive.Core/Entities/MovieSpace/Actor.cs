namespace Archive.Core.Entities.MovieSpace
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public IList<Movie>? Movies { get; set; }
    }
}