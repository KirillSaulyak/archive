using Archive.Core.DTOs.MovieSpace.Admin.Category;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Core.Abstractions.MovieSpace.Services.Admin
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(CategoryCreateDto categoryCreateDto);
        Task<IList<CategoryInfoShortDto>> findAllCategoryInfoShortDtos();
        Task<IList<Category>> FindAllCategoryByIdsTrackingAsync(IList<Guid> ids);
        Task<CategoryUpdateDto> GetCategoryByIdForUpdateAsync(Guid id);
        Task UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);
        Task<IList<Category>> GetAllCategoriesAsync();
        Task DeleteCategoryById(Guid id);
    }
}

