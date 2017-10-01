using Controle.IO.Domain.Enum;
using FluentValidation;
using System;

namespace Controle.IO.Domain.Models
{
    public class ClientePf : Cliente<ClientePf>
    {
        public ClientePf()
        {
            CodTipoPessoa = (int)EnumTipoPessoa.PessoaFisica;
        }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public override bool SeValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }

        private void Validar()
        {
            ValidaNome();
            ValidaCpf();
            ValidaDataNascimento();
            ValidationResult = Validate(this);
        }

        private void ValidaNome()
        {
            RuleFor(c => c.Nome)
              .NotEmpty().WithMessage("O nome do cliente precisa ser fornecido")
              .Length(2, 150).WithMessage("O nome do Cliente precisa ter entre 2 e 150 caracteres");
        }

        private void ValidaCpf()
        {
            RuleFor(c => c.Cpf)
              .Length(11).WithMessage("O número do Cpf inválido");
        }

        private void ValidaDataNascimento()
        {
            RuleFor(c => c.DataNascimento)
                    .LessThan(DateTime.Now.Date.AddYears(-10))
                    .WithMessage("A data de nascimento deve ser menor que a data do final do evento");
        }
    }
}
