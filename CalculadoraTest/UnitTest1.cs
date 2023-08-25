using Calculadora;
using System;
using Xunit;

namespace CalculadoraTest
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Testa o metodo de soma da Calculadora")]
        [Trait("Calculo", "Somar")]
        public void Somar_DoisDouble_RetornarDouble()
        {
            //Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 6;

            //Act
            var soma = Calculo.Somar(num1, num2);

            //Assert
            Assert.Equal(valorEsperado, soma);
        }

        //[Fact(Skip = "Teste ainda não disponível")]
        [Fact(DisplayName = "Testa o metodo de subtração da Calculadora")]
        [Trait("Calculo", "Subtrair")]
        public void Subtrair_DoisDouble_RetornarDouble()
        {
            //Arrange
            var num1 = 8;
            var num2 = 6;
            var valorEsperado = 2;

            //Act
            var subtracao = Calculo.Subtrair(num1, num2);

            //Assert
            Assert.Equal(valorEsperado, subtracao);
        }

        [Fact(DisplayName ="Testa o metodo de multiplicação da Calculadora")]
        [Trait("Calculo", "Multiplicar")]
        public void Multiplicar_DoisDouble_RetornarDouble()
        {
            //Arrange
            var num1 = 7.8;
            var num2 = 3.14;
            var valorEsperado = 24.492;

            //Act
            var multiplicacao = Calculo.Multiplicar(num1, num2);

            //Assert
            Assert.Equal(valorEsperado, multiplicacao);
        }

        [Fact(DisplayName = "Testa o metodo de divisão da Calculadora")]
        [Trait("Calculo", "Dividir")]
        public void Dividir_DoisDouble_RetornarDouble()
        {
            var num1 = 10;
            var num2 = 2;
            var valorEsperado = 5;

            var divisao = Calculo.Dividir(num1, num2);

            Assert.Equal(valorEsperado, divisao);
        }

        [Fact(DisplayName = "Testa o metodo ehpar da Calculadora")]
        [Trait("Calculo", "EhPar")]
        public void Validar_Se_Eh_Par_RetornarBoolean()
        {
            var num1 = 2;
            var valorEsperado = true;

            var ehPar = Calculo.EhNumeroPar(num1);

            Assert.Equal(valorEsperado, ehPar);
        }
    }
}
