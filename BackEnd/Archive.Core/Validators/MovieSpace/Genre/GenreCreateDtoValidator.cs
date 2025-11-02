using Archive.Core.DTOs.MovieSpace.admin.Genre;
using Archive.Core.Entities.MovieSpace;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Validators.MovieSpace.Genre
{
    public class GenreCreateDtoValidator : AbstractValidator<GenreCreateDto>
    {
        public GenreCreateDtoValidator()
        {
            RuleFor(dto => dto.Name)
                .NotEmpty().WithMessage("Введите название жанра")
                .MaximumLength(100).WithMessage("Длина не должна превышать 45 символов");
        }
    }
}

