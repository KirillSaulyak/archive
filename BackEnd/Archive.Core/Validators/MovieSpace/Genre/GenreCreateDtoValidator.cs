using Archive.Core.DTOs.MovieSpace.admin.Genre;
using FluentValidation;

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

