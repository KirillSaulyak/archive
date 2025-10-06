using Archive.Core.Entities.Movie;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Validators.Movie
{
    public class ActorValidator : AbstractValidator<Actor>
    {
        public ActorValidator()
        {
            RuleFor(actor => actor.FullName).NotEmpty().Length(2,5).WithMessage("lol kek");
        }
    }
}
