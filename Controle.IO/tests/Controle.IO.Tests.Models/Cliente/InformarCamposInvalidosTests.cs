using Controle.IO.Domain.Models;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Controle.IO.Tests.Models.Cliente
{
    public class InformarCamposInvalidosTests
    {
        private readonly ITestOutputHelper _output;

        public InformarCamposInvalidosTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void InformarCamposValidos()
        {
            var cliente = new ClientePf()
            {
                Nome = "S",
                DataNascimento = DateTime.Now.Date,
                Cpf = "33"
            };

            cliente.SeValido();

            var retornoErros = cliente.ValidationResult.Errors;

            foreach (var erros in retornoErros)
            {
                _output.WriteLine("Mensagem: {0}", erros);
            }

            Assert.False(cliente.SeValido());
        }
    }
}
