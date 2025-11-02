using Archive.Core.Abstractions.MovieSpace.Services.admin;
using Archive.Core.DTOs.MovieSpace.Admin.Movie;
using Archive.Core.Entities.MovieSpace;
using Archive.Core.Exceptions;
using Archive.Core.Mappers.MovieSpace.Admin;
using Archive.Infrastructure.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text; 
using System.Threading.Tasks;

namespace Archive.Services.MovieSpace.admin
{
    public class MovieService(ArchiveDbContext archiveDbContext, IMapper movieMapper) : IMovieService
    {
        
        public async Task CreateMovieAsync(MovieCreateDto movieCreateDto)
        {
            await archiveDbContext.Movies.AddAsync(movieMapper.Map<Movie>(movieCreateDto));
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
         
        public async Task UpdateMovieAsync(MovieUpdateDto movieUpdateDto)
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
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task DeleteMovieById(Guid id)
        {
            Movie movieForDelete = await archiveDbContext.Movies.FindAsync(id) ?? throw new EntityNotFoundException("Can`t delete movie. Wrong id: " + id);
            archiveDbContext.Movies.Remove(movieForDelete);
            await archiveDbContext.SaveChangesAsync();
        }
    }
}
