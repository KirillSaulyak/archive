using Archive.Core.DTOs.MovieSpace.admin.Director;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

