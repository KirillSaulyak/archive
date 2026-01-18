using Archive.Core.DTOs.MovieSpace.Admin.Genre;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Genre
{
    public class GenreUpdateDtoValidator : AbstractValidator<GenreUpdateDto>
    {
        public GenreUpdateDtoValidator()
        {
            RuleFor(dto => dto.Id)
                .NotEmpty().WithMessage("Id обязателен");

            RuleFor(dto => dto.Name)
                .NotEmpty().WithMessage("Введите название жанра")
                .MaximumLength(100).WithMessage("Длина не должна превышать 45 символов");
        }
    }
}

