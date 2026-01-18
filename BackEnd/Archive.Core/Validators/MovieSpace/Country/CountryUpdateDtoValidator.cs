using Archive.Core.DTOs.MovieSpace.Admin.Country;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Country
{
    public class CountryUpdateDtoValidator : AbstractValidator<CountryUpdateDto>
    {
        public CountryUpdateDtoValidator()
        {
            RuleFor(dto => dto.Id)
                .NotEmpty().WithMessage("Id обязателен");

            RuleFor(dto => dto.Name)
                .NotEmpty().WithMessage("Введите название страны")
                .MaximumLength(100).WithMessage("Длина не должна превышать 100 символов");
        }
    }
}

