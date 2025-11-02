using Archive.Core.DTOs.MovieSpace.admin.Category;
using Archive.Core.Entities.MovieSpace;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Validators.MovieSpace.Category
{
    public class CategoryCreateDtoValidator : AbstractValidator<CategoryCreateDto>
    {
        public CategoryCreateDtoValidator()
        {
            RuleFor(dto => dto.Name)
                .NotEmpty().WithMessage("Введите название категории")
                .MaximumLength(100).WithMessage("Длина не должна превышать 45 символов");
        }
    }
}

