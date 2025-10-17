using Archive.Core.Abstractions.Movies.Repositories;
using Archive.Core.Entities.Movies;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Infrastructure.Persistence.Repositories.Movies
{
    public class ActorRepository(ArchiveDbContext _archiveDbContext) : IActorRepository
    {
        private readonly ArchiveDbContext _archiveDbContext;

        public async Task CreateActorAsync(Actor actor)
        {
            await _archiveDbContext.Actors.AddAsync(actor);
            await _archiveDbContext.SaveChangesAsync();
        }

        public async Task<Actor> GetActorByIdAsync(Guid id)
        {
            return await _archiveDbContext.Actors.FindAsync(id);
        }

        public async Task<IList<Actor>> GetAllActorsAsync()
        {
            return await _archiveDbContext.Actors.AsNoTracking().ToListAsync();
        }

        public async Task<IList<Actor>> GetActorsByIdsAsync(IList<Guid> ids)
        {
            return await _archiveDbContext.Actors
                .AsNoTracking()
                .Where(actor => ids.Contains(actor.Id))
                .ToListAsync();
        }

        public async Task DeleteActorById(Guid id)
        {
            Actor toDelete = await GetActorByIdAsync(id);
            _archiveDbContext.Actors.Remove(toDelete);
            await _archiveDbContext.SaveChangesAsync();
        }
    }
}
