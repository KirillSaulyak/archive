using Archive.Core.Abstractions.MovieSpace.Services.admin;
using Archive.Core.DTOs.MovieSpace.admin.Actor;
using Archive.Core.Entities.MovieSpace;
using Archive.Core.Exceptions;
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
    public class ActorService(ArchiveDbContext archiveDbContext, IMapper actorMapper) : IActorService
    {
        
        public async Task CreateActorAsync(ActorCreateDto actorCreateDto)
        {
            await archiveDbContext.Actors.AddAsync(actorMapper.Map<Actor>(actorCreateDto));
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<ActorUpdateDto> GetActorByIdForUpdateAsync(Guid id)
        {
            Actor actor = await archiveDbContext.Actors.AsNoTracking().FirstOrDefaultAsync(actor => actor.Id == id) ?? throw new EntityNotFoundException("Can`t find actor with id: " + id);
            return actorMapper.Map<ActorUpdateDto>(actor); 
        }
         
        public async Task UpdateActorAsync(ActorUpdateDto actorUpdateDto)
        {
            Actor actor = await archiveDbContext.Actors.FindAsync(actorUpdateDto.Id) ?? throw new EntityNotFoundException("Can`t update actor. Wrong id: " + actorUpdateDto.Id);
            actorMapper.Map(actorUpdateDto, actor);
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<IList<Actor>> GetAllActorsAsync()
        {
            return await archiveDbContext.Actors.AsNoTracking().ToListAsync();
        }

        public async Task DeleteActorById(Guid id)
        {
            Actor actorForDelete = await archiveDbContext.Actors.FindAsync(id) ?? throw new EntityNotFoundException("Can`t delete actor. Wrong id: " + id);
            archiveDbContext.Actors.Remove(actorForDelete);
        }
    }
}
