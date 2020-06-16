using System;
using Xunit;
using Calculadora;

namespace CalculadoraTestes
{
    public class TestesSoma
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(1, -2, -1)]
        public void Soma(double a, double b, double resultado)
        {
            var teste = Calcular.soma(a, b);
            Assert.Equal(teste,resultado);
        }
    }
}
