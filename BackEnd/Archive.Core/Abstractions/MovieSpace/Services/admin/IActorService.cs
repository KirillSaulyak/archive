using Archive.Core.DTOs.MovieSpace.Admin.Actor;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.Admin
{
    public interface IActorService
    {
        Task CreateActorAsync(ActorCreateDto actorCreateDto);
        Task<IList<ActorInfoShortDto>> findAllActorInfoShortDtos();
        Task<IList<Actor>> FindAllActorByIdsTrackingAsync(IList<Guid> ids);
        Task<ActorUpdateDto> GetActorByIdForUpdateAsync(Guid id);
        Task UpdateActorAsync(ActorUpdateDto actorUpdateDto);
        Task<IList<Actor>> GetAllActorsAsync();
        Task DeleteActorById(Guid id);
    }
}
