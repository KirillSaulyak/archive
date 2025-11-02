using Archive.Core.DTOs.MovieSpace.admin.Category;
using Archive.Core.Entities.MovieSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Abstractions.MovieSpace.Services.admin
{
    public interface ICategoryService
    {
        Task CreateCategoryAsync(CategoryCreateDto categoryCreateDto);
        Task<CategoryUpdateDto> GetCategoryByIdForUpdateAsync(Guid id);
        Task UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);
        Task<IList<Category>> GetAllCategoriesAsync();
        Task DeleteCategoryById(Guid id);
    }
}

