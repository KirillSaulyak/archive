using Archive.Core.Abstractions.MovieSpace.Services.Admin;
using Archive.Core.DTOs.MovieSpace.Admin.Translator;
using Archive.Core.Entities.MovieSpace;
using Archive.Core.Exceptions;
using Archive.Infrastructure.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Archive.Services.Services.MovieSpace.Admin
{
    public class TranslatorService(ArchiveDbContext archiveDbContext, IMapper translatorMapper) : ITranslatorService
    {

        public async Task CreateTranslatorAsync(TranslatorCreateDto translatorCreateDto)
        {
            await archiveDbContext.Translators.AddAsync(translatorMapper.Map<Translator>(translatorCreateDto));
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<IList<TranslatorInfoShortDto>> findAllTranslatorInfoShortDtos()
        {
            IList<Translator> translators = await archiveDbContext.Translators.AsNoTracking().ToListAsync();
            return translatorMapper.Map<IList<TranslatorInfoShortDto>>(translators);
        }

        public async Task<IList<Translator>> FindAllTranslatorByIdsTrackingAsync(IList<Guid> ids)
        {
            return await archiveDbContext.Translators.Where(translator => ids.Contains(translator.Id)).ToListAsync();
        }

        public async Task<TranslatorUpdateDto> GetTranslatorByIdForUpdateAsync(Guid id)
        {
            Translator translator = await archiveDbContext.Translators.AsNoTracking().FirstOrDefaultAsync(translator => translator.Id == id) ?? throw new EntityNotFoundException("Can`t find translator with id: " + id);
            return translatorMapper.Map<TranslatorUpdateDto>(translator);
        }

        public async Task UpdateTranslatorAsync(TranslatorUpdateDto translatorUpdateDto)
        {
            Translator translator = await archiveDbContext.Translators.FindAsync(translatorUpdateDto.Id) ?? throw new EntityNotFoundException("Can`t update translator. Wrong id: " + translatorUpdateDto.Id);
            translatorMapper.Map(translatorUpdateDto, translator);
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<IList<Translator>> GetAllTranslatorsAsync()
        {
            return await archiveDbContext.Translators.AsNoTracking().ToListAsync();
        }

        public async Task DeleteTranslatorById(Guid id)
        {
            Translator translatorForDelete = await archiveDbContext.Translators.FindAsync(id) ?? throw new EntityNotFoundException("Can`t delete translator. Wrong id: " + id);
            archiveDbContext.Translators.Remove(translatorForDelete);
        }
    }
}

