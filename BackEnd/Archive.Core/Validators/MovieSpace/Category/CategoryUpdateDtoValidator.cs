using Archive.Core.DTOs.MovieSpace.Admin.Category;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Category
{
    public class CategoryUpdateDtoValidator : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateDtoValidator()
        {
            RuleFor(dto => dto.Id)
                .NotEmpty().WithMessage("Id обязателен");

            RuleFor(dto => dto.Name)
                .NotEmpty().WithMessage("Введите название категории")
                .MaximumLength(100).WithMessage("Длина не должна превышать 45 символов");
        }
    }
}

