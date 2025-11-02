using Archive.Core.DTOs.MovieSpace.admin.Theme;
using Archive.Core.Entities.MovieSpace;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

