using APICalculadoraSimples.Interface;
using APICalculadoraSimples.Models;

namespace APICalculadoraSimples.Services
{
    public class CalculadoraService : ICalculadoraInterface
    {
        public async Task<Calculadora> Somar(double valor1, double valor2)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Valor1 = valor1;
            calculadora.Valor2 = valor2;
            calculadora.Resultado = valor1 + valor2;

            return calculadora;
        }

        public async Task<Calculadora> Subtrair(double valor1, double valor2)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Valor1 = valor1;
            calculadora.Valor2 = valor2;
            calculadora.Resultado = valor1 - valor2;

            return calculadora;
        }

        public async Task<Calculadora> Multiplicacao(double valor1, double valor2)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Valor1 = valor1;
            calculadora.Valor2 = valor2;
            calculadora.Resultado = valor1 * valor2;

            return calculadora;
        }

        public async Task<Calculadora> Divisao(double valor1, double valor2)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Valor1 = valor1;
            calculadora.Valor2 = valor2;
            calculadora.Resultado = valor1 / valor2;

            return calculadora;
        }

        public async Task<Calculadora> Potenciacao(double valor1, double valor2)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Valor1 = valor1;
            calculadora.Valor2 = valor2;
            calculadora.Resultado = Math.Pow(valor1, valor2);

            return calculadora;
        }
    }
}
