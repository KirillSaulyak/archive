using Archive.Core.DTOs.MovieSpace.admin.Country;
using Archive.Core.Entities.MovieSpace;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Validators.MovieSpace.Country
{
    public class CountryCreateDtoValidator : AbstractValidator<CountryCreateDto>
    {
        public CountryCreateDtoValidator()
        {
            RuleFor(dto => dto.Name)
                .NotEmpty().WithMessage("Введите название страны")
                .MaximumLength(100).WithMessage("Длина не должна превышать 100 символов");
        }
    }
}

