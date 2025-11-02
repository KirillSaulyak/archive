using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.DTOs.MovieSpace.admin.Category
{
    public record CategoryUpdateDto(Guid Id, string? Name);
}

