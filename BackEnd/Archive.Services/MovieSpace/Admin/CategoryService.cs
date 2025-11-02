using Archive.Core.Abstractions.MovieSpace.Services.admin;
using Archive.Core.DTOs.MovieSpace.admin.Category;
using Archive.Core.Entities.MovieSpace;
using Archive.Core.Exceptions;
using Archive.Core.Mappers.MovieSpace.Admin;
using Archive.Infrastructure.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text; 
using System.Threading.Tasks;

namespace Archive.Services.MovieSpace.admin
{
    public class CategoryService(ArchiveDbContext archiveDbContext, IMapper categoryMapper) : ICategoryService
    {
        
        public async Task CreateCategoryAsync(CategoryCreateDto categoryCreateDto)
        {
            await archiveDbContext.Categories.AddAsync(categoryMapper.Map<Category>(categoryCreateDto));
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<CategoryUpdateDto> GetCategoryByIdForUpdateAsync(Guid id)
        {
            Category category = await archiveDbContext.Categories.AsNoTracking().FirstOrDefaultAsync(category => category.Id == id) ?? throw new EntityNotFoundException("Can`t find category with id: " + id);
            return categoryMapper.Map<CategoryUpdateDto>(category); 
        }
         
        public async Task UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto)
        {
            Category category = await archiveDbContext.Categories.FindAsync(categoryUpdateDto.Id) ?? throw new EntityNotFoundException("Can`t update category. Wrong id: " + categoryUpdateDto.Id);
            categoryMapper.Map(categoryUpdateDto, category);
            await archiveDbContext.SaveChangesAsync();
        }

        public async Task<IList<Category>> GetAllCategoriesAsync()
        {
            return await archiveDbContext.Categories.AsNoTracking().ToListAsync();
        }

        public async Task DeleteCategoryById(Guid id)
        {
            Category categoryForDelete = await archiveDbContext.Categories.FindAsync(id) ?? throw new EntityNotFoundException("Can`t delete category. Wrong id: " + id);
            archiveDbContext.Categories.Remove(categoryForDelete);
        }
    }
}

