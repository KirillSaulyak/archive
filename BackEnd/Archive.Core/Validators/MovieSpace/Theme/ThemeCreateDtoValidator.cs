using Archive.Core.DTOs.MovieSpace.admin.Theme;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Theme
{
    public class ThemeCreateDtoValidator : AbstractValidator<ThemeCreateDto>
    {
        public ThemeCreateDtoValidator()
        {
            RuleFor(dto => dto.Name)
                .NotEmpty().WithMessage("Введите название темы")
                .MaximumLength(100).WithMessage("Длина не должна превышать 100 символов");
        }
    }
}

