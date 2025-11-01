using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.DTOs.MovieSpace.admin.Actor
{
    public record ActorUpdateDto(Guid Id, string? FullName);
}
