using FluentValidation;
using FluentValidation.Results;

namespace Controle.IO.Domain.Core.Models
{
    public abstract class Entity<T>: AbstractValidator<T> where T: Entity<T> 
    {
        protected Entity()
        {
            ValidationResult = new ValidationResult();
        }

        public abstract bool SeValido();

        public ValidationResult ValidationResult { get; protected set; }
    }
}
