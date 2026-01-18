using Archive.Core.DTOs.MovieSpace.Admin.Translator;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Translator
{
    public class TranslatorUpdateDtoValidator : AbstractValidator<TranslatorUpdateDto>
    {
        public TranslatorUpdateDtoValidator()
        {
            RuleFor(dto => dto.Id)
                .NotEmpty().WithMessage("Id обязателен");

            RuleFor(dto => dto.FullName)
                .NotEmpty().WithMessage("Введите полное имя переводчика")
                .MaximumLength(100).WithMessage("Длина не должна превышать 100 символов");
        }
    }
}

