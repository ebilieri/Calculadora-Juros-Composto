using CalculaJuros.Models;
using CalculaJuros.Services;
using System;
using Xunit;

namespace CalculaJuros.Tests
{
    public class CalculaJurosTest
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosTest()
        {
            _calculaJurosService = new CalculaJurosComposto();
        }

        [Fact]
        public void TestCalcularJurosComposto()
        {
            var valorEsperado = 105.10M;
            var calcularJuros = new CalcularJuros(100, 5);

            var retorno = _calculaJurosService.CalculaJuros(calcularJuros);

            Assert.Equal(valorEsperado, retorno);
        }

        [Fact]
        public void TestCalcularJurosCompostoTruncate()
        {
            var valorEsperado = 105.62M;
            var calcularJuros = new CalcularJuros(100.50, 5);

            var retorno = _calculaJurosService.CalculaJuros(calcularJuros);

            Assert.Equal(valorEsperado, retorno);
        }
    }
}
