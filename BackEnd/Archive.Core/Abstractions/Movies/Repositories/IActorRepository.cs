using Archive.Core.Entities.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Abstractions.Movies.Repositories
{
    public interface IActorRepository 
    {
        Task CreateActorAsync(Actor actor);
        Task<Actor> GetActorByIdAsync(Guid id);
        Task<IList<Actor>> GetAllActorsAsync();
        Task<IList<Actor>> GetActorsByIdsAsync(IList<Guid> ids);
        Task DeleteActorById(Guid id);
    }
}
