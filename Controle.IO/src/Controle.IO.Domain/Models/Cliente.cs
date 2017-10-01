using FluentValidation;
using FluentValidation.Results;

namespace Controle.IO.Domain.Models
{
    public abstract class Cliente<T> : AbstractValidator<T> where T : Cliente<T>
    {
        protected Cliente()
        {
            ValidationResult = new ValidationResult();
        }

        public long CodCliente { get; set; }

        public int CodTipoPessoa { get; set; }

        public bool Ativo { get; set; }

        public abstract bool SeValido();

        public ValidationResult ValidationResult { get; protected set; }
    }
}
