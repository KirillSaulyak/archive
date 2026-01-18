using Archive.Core.DTOs.MovieSpace.Admin.Translator;
using FluentValidation;

namespace Archive.Core.Validators.MovieSpace.Translator
{
    public class TranslatorCreateDtoValidator : AbstractValidator<TranslatorCreateDto>
    {
        public TranslatorCreateDtoValidator()
        {
            RuleFor(dto => dto.FullName)
                .NotEmpty().WithMessage("Введите полное имя переводчика")
                .MaximumLength(100).WithMessage("Длина не должна превышать 100 символов");
        }
    }
}

