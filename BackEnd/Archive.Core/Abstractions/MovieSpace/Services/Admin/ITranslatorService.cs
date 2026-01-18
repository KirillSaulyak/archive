using Archive.Core.DTOs.MovieSpace.Admin.Translator;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.Admin
{
    public interface ITranslatorService
    {
        Task CreateTranslatorAsync(TranslatorCreateDto translatorCreateDto);
        Task<IList<TranslatorInfoShortDto>> findAllTranslatorInfoShortDtos();
        Task<IList<Translator>> FindAllTranslatorByIdsTrackingAsync(IList<Guid> ids);
        Task<TranslatorUpdateDto> GetTranslatorByIdForUpdateAsync(Guid id);
        Task UpdateTranslatorAsync(TranslatorUpdateDto translatorUpdateDto);
        Task<IList<Translator>> GetAllTranslatorsAsync();
        Task DeleteTranslatorById(Guid id);
    }
}

