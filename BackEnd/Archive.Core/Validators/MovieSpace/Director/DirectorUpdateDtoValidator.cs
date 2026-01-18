using Archive.Core.DTOs.MovieSpace.Admin.Director;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Director
{
    public class DirectorUpdateDtoValidator : AbstractValidator<DirectorUpdateDto>
    {
        public DirectorUpdateDtoValidator()
        {
            RuleFor(dto => dto.Id)
                .NotEmpty().WithMessage("Id обязателен");

            RuleFor(dto => dto.FullName)
                .NotEmpty().WithMessage("Введите полное имя режиссера")
                .MaximumLength(100).WithMessage("Длина не должна превышать 100 символов");
        }
    }
}

