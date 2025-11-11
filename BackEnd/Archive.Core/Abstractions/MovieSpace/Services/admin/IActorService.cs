using Archive.Core.DTOs.MovieSpace.admin.Actor;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.admin
{
    public interface IActorService
    {
        Task CreateActorAsync(ActorCreateDto actorCreateDto);
        Task<ActorUpdateDto> GetActorByIdForUpdateAsync(Guid id);
        Task UpdateActorAsync(ActorUpdateDto actorUpdateDto);
        Task<IList<Actor>> GetAllActorsAsync();
        Task DeleteActorById(Guid id);
    }
}
