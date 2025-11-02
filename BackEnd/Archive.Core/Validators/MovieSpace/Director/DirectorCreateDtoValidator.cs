using Archive.Core.DTOs.MovieSpace.admin.Director;
using Archive.Core.Entities.MovieSpace;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

