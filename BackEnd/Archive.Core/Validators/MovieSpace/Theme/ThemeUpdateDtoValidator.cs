using Archive.Core.DTOs.MovieSpace.admin.Theme;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

