using Archive.Core.DTOs.MovieSpace.admin.Country;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

