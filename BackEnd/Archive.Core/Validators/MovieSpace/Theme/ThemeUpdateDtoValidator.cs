using Archive.Core.DTOs.MovieSpace.Admin.Theme;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Theme
{
    public class ThemeUpdateDtoValidator : AbstractValidator<ThemeUpdateDto>
    {
        public ThemeUpdateDtoValidator()
        {
            RuleFor(dto => dto.Id)
                .NotEmpty().WithMessage("Id обязателен");

            RuleFor(dto => dto.Name)
                .NotEmpty().WithMessage("Введите название темы")
                .MaximumLength(100).WithMessage("Длина не должна превышать 100 символов");
        }
    }
}

