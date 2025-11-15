using Archive.Core.DTOs.MovieSpace.admin.Director;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Director
{
    public class DirectorCreateDtoValidator : AbstractValidator<DirectorCreateDto>
    {
        public DirectorCreateDtoValidator()
        {
            RuleFor(dto => dto.FullName)
                .NotEmpty().WithMessage("Введите полное имя режиссера")
                .MaximumLength(100).WithMessage("Длина не должна превышать 100 символов");
        }
    }
}

