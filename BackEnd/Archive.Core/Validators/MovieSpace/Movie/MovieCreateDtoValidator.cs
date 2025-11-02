using Archive.Core.DTOs.MovieSpace.Admin.Movie;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Validators.MovieSpace.Movie
{
    public class MovieCreateDtoValidator : AbstractValidator<MovieCreateDto>
    {
        public MovieCreateDtoValidator()
        {
            RuleFor(dto => dto.Release).NotEmpty().WithMessage("Введите дату");
        }
    }
}
