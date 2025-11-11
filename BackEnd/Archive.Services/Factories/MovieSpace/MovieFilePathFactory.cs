using Archive.Services.Abstractions.Factories.Common;
using Archive.Services.Abstractions.Factories.MovieSpace;
using Archive.Services.Enums.Common;
using Archive.Services.Enums.MovieSpace;

namespace Archive.Services.Factories.MovieSpace
{
    public class MovieFilePathFactory(IFilePathFactory filePathFactory) : IMovieFilePathFactory
    {
        public string GenerateFilePath(MovieFolderType movieFolderType)
        {
            return filePathFactory.GenerateFilePath(EntitySpace.Movie, movieFolderType.ToString());
        }
    }
}
