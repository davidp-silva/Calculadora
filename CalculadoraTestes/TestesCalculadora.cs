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
        public void Soma(double a, double b, double valor)
        {
            var resultado = Calcula.Somar(a, b);
            resultado.Should().Be
                (valor, $"Soma não condiz com o esperado ( {valor} )");
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(350,50 ,300)]
        public void Subtrair(double a,double b, double valor)
        {
            var resultado = Calcula.Subtrair(a, b);
            resultado.Should()
                .Be(valor, $"Subtração não condiz com o esperado ( {valor} )");
        }
        [Theory]
        [InlineData(1, 2, 0.5 )]
        [InlineData(350, 50, 7)]
        [InlineData(0, 50, 0)]
        public void Dividir(double a, double b, double valor)
        {
            var resultado = Calcula.Dividir(a, b);
            resultado.Should()
                .Be(valor, $"Divisão não condiz com o esperado ( {valor} )");
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(350, 50, 17500)]
        [InlineData(0, 50, 0)]
        public void Multiplicar(double a, double b, double valor)
        {
            var resultado = Calcula.Multiplicar(a, b);
            resultado.Should()
                .Be(valor, $"Divisão não condiz com o esperado ( {valor} )");
        }
    }
}
