using Archive.Core.DTOs.MovieSpace.admin.Translator;
using Archive.Core.Entities.MovieSpace;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

