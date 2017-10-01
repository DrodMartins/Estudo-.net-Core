using Controle.IO.Domain.Models;
using System;
using Xunit;

namespace Controle.IO.Tests.Models.Cliente
{
    public class InformarCamposValidosTests
    {
        [Fact]
        public void InformarCamposValidos()
        {
            var cliente = new ClientePf()
            {
                Nome = "DANIEL RODRIDRIGUES MARTINS",
                DataNascimento = DateTime.Now.Date.AddYears(-15),
                Cpf = "22233344455"
            };

            Assert.True(cliente.SeValido());
        }
    }
}
