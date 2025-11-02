using Archive.Core.DTOs.MovieSpace.admin.Actor;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
