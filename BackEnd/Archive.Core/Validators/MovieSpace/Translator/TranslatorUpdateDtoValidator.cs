using Archive.Core.DTOs.MovieSpace.admin.Translator;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

