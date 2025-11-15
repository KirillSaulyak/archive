using Archive.Core.DTOs.MovieSpace.admin.Actor;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Actor
{
    public class ActorUpdateDtoValidator : AbstractValidator<ActorUpdateDto>
    {
        public ActorUpdateDtoValidator()
        {
            RuleFor(dto => dto.FullName)
                .NotEmpty().WithMessage("Введите полное имя актера")
                .MaximumLength(100).WithMessage("Длина не должна превышать 100 символов");
        }
    }
}
