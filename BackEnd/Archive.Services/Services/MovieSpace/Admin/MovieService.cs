using Archive.Core.Abstractions.Common.Utilities;
using Archive.Core.Abstractions.MovieSpace.Services.Admin;
using Archive.Core.DTOs.Common;
using Archive.Core.DTOs.MovieSpace.Admin.Movie;
using Archive.Core.Entities.MovieSpace;
using Archive.Core.Exceptions;
using Archive.Infrastructure.Persistence;
using Archive.Services.Abstractions.Factories.MovieSpace;
using Archive.Services.Enums.MovieSpace;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Archive.Services.Services.MovieSpace.Admin
{
    public class MovieService(
        ArchiveDbContext archiveDbContext,
        IMapper movieMapper,
        IFileManager fileManager,
        IMovieFilePathFactory movieFilePathFactory,
        IActorService actorService,
        ICategoryService categoryService,
        ICountryService countryService,
        IDirectorService directorService,
        IGenreService genreService,
        IThemeService themeService,
        ITranslatorService translatorService) : IMovieService
    {
        private string PathToPoster { get; } = movieFilePathFactory.GenerateFilePath(MovieFolderType.Posters);

        public async Task CreateMovieAsync(MovieCreateDto movieCreateDto, UploadFileDto uploadFileDto)
        {
            Movie movieForCreate = movieMapper.Map<Movie>(movieCreateDto);
            movieForCreate.PosterFileExtension = uploadFileDto.FileExtension;

            movieForCreate.Categories = movieCreateDto.CategoryIds?.Any() == true ? await categoryService.FindAllCategoryByIdsTrackingAsync(movieCreateDto.CategoryIds) : throw new ArgumentNullException("Category can`t be null");

            movieForCreate.Actors = movieCreateDto.ActorIds?.Any() == true ? await actorService.FindAllActorByIdsTrackingAsync(movieCreateDto.ActorIds) : null;
            movieForCreate.Countries = movieCreateDto.CountryIds?.Any() == true ? await countryService.FindAllCountryByIdsTrackingAsync(movieCreateDto.CountryIds) : null;
            movieForCreate.Directors = movieCreateDto.DirectorIds?.Any() == true ? await directorService.FindAllDirectorByIdsTrackingAsync(movieCreateDto.DirectorIds) : null;
            movieForCreate.Genres = movieCreateDto.GenreIds?.Any() == true ? await genreService.FindAllGenreByIdsTrackingAsync(movieCreateDto.GenreIds) : null;
            movieForCreate.Themes = movieCreateDto.ThemeIds?.Any() == true ? await themeService.FindAllThemeByIdsTrackingAsync(movieCreateDto.ThemeIds) : null;
            movieForCreate.Translators = movieCreateDto.TranslatorIds?.Any() == true ? await translatorService.FindAllTranslatorByIdsTrackingAsync(movieCreateDto.TranslatorIds) : null;

            await archiveDbContext.Movies.AddAsync(movieForCreate);

            await fileManager.SaveFileAsync(uploadFileDto, movieForCreate.Id.ToString(), PathToPoster);

            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<MovieUpdateDto> GetMovieByIdForUpdateAsync(Guid id)
        {
            Movie movie = await archiveDbContext.Movies
                .AsNoTracking()
                .Include(movie => movie.Actors)
                .Include(movie => movie.Categories)
                .Include(movie => movie.Countries)
                .Include(movie => movie.Directors)
                .Include(movie => movie.Genres)
                .Include(movie => movie.Themes)
                .Include(movie => movie.Translators)
                .FirstOrDefaultAsync(movie => movie.Id == id) ?? throw new EntityNotFoundException("Can`t find movie with id: " + id);

            return movieMapper.Map<MovieUpdateDto>(movie);
        }

        public async Task UpdateMovieAsync(MovieUpdateDto movieUpdateDto, UploadFileDto? uploadFileDto)
        {
            Movie movie = await archiveDbContext.Movies
                .Include(movie => movie.Actors)
                .Include(movie => movie.Categories)
                .Include(movie => movie.Countries)
                .Include(movie => movie.Directors)
                .Include(movie => movie.Genres)
                .Include(movie => movie.Themes)
                .Include(movie => movie.Translators)
                .FirstOrDefaultAsync(movie => movie.Id == movieUpdateDto.Id) ?? throw new EntityNotFoundException("Can`t update movie. Wrong id: " + movieUpdateDto.Id);

            movieMapper.Map(movieUpdateDto, movie);

            if (uploadFileDto != null)
            {
                movie.PosterFileExtension = uploadFileDto.FileExtension;
                await fileManager.SaveFileAsync(uploadFileDto, movie.Id.ToString(), PathToPoster);
            }
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task DeleteMovieById(Guid id)
        {
            Movie movieForDelete = await archiveDbContext.Movies.FindAsync(id) ?? throw new EntityNotFoundException("Can`t delete movie. Wrong id: " + id);
            string pathToDeletePoster = Path.Combine(PathToPoster, movieForDelete.Id.ToString() + movieForDelete.PosterFileExtension);
            await fileManager.DeleteFileAsync(pathToDeletePoster);

            archiveDbContext.Movies.Remove(movieForDelete);
            await archiveDbContext.SaveChangesAsync();
        }
    }
}
