using Archive.Services.Enums.MovieSpace;

namespace Archive.Services.Abstractions.Factories.MovieSpace
{
    public interface IMovieFilePathFactory
    {
        string GenerateFilePath(MovieFolderType movieFolderType);
    }
}