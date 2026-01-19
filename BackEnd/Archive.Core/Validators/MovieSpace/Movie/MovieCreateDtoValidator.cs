using Archive.Core.DTOs.MovieSpace.Admin.Movie;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Movie
{
    public class MovieCreateDtoValidator : AbstractValidator<MovieCreateDto>
    {
        public MovieCreateDtoValidator()
        {
            RuleFor(dto => dto.Duration)
                .GreaterThanOrEqualTo(0).WithMessage("Длительность не может быть отрицательна")
                .LessThanOrEqualTo(1000).WithMessage("Слишком большая длительность в минутах");
            RuleFor(dto => dto.Description)
                .MaximumLength(1000).WithMessage("Описание не может превышать 1000 символов");
            RuleFor(dto => dto.Name)
                .NotEmpty().WithMessage("Название не может быть пустым")
                .MaximumLength(200).WithMessage("Название не может превышать 200 символов");
            RuleFor(dto => dto.OriginalName)
                .MaximumLength(200).WithMessage("Оригинальное название не может превышать 200 символов");
            RuleFor(dto => dto.CategoryIds)
                .NotEmpty().WithMessage("Категория кино обязательная для заполнения");

        }
    }
}
