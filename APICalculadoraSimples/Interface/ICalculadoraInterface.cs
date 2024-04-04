using APICalculadoraSimples.Models;

namespace APICalculadoraSimples.Interface
{
    public interface ICalculadoraInterface
    {
        Task<Calculadora> Somar(double valor1, double valor2);
        Task<Calculadora> Subtrair(double valor1, double valor2);
        Task<Calculadora> Divisao(double valor1, double valor2);
        Task<Calculadora> Multiplicacao(double valor1, double valor2);
        Task<Calculadora> Potenciacao(double valor1, double valor2);
    }
}
