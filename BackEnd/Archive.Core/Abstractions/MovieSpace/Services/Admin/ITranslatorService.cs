using Archive.Core.DTOs.MovieSpace.admin.Translator;
using Archive.Core.Entities.MovieSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Abstractions.MovieSpace.Services.admin
{
    public interface ITranslatorService
    {
        Task CreateTranslatorAsync(TranslatorCreateDto translatorCreateDto);
        Task<TranslatorUpdateDto> GetTranslatorByIdForUpdateAsync(Guid id);
        Task UpdateTranslatorAsync(TranslatorUpdateDto translatorUpdateDto);
        Task<IList<Translator>> GetAllTranslatorsAsync();
        Task DeleteTranslatorById(Guid id);
    }
}

