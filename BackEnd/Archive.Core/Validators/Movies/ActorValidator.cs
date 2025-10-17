using Archive.Core.Entities.Movies;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive.Core.Validators.Movies
{
    public class ActorValidator : AbstractValidator<Actor>
    {
        public ActorValidator()
        {
            RuleFor(actor => actor.FullName).NotEmpty().Length(2,5).WithMessage("lol kek");
        }
    }
}
