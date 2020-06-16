using System;
using Xunit;
using Calculadora;
using FluentAssertions;

namespace CalculadoraTestes
{
    public class TestesCalculadora
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(1, -2, -1)]
        public void Soma(double a, double b, double resultado)
        {
            var teste = Calcula.Somar(a, b);
            teste.Should().Be
                (resultado, $"Soma não condiz com o esperado ( {resultado} )");
        }


    }
}
