using APICalculadoraSimples.Interface;
using APICalculadoraSimples.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICalculadoraSimples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalculadoraInterface _calculadoraInterface;
        public CalculadoraController(ICalculadoraInterface calculadoraInterface)
        {
            _calculadoraInterface = calculadoraInterface;
        }

        [HttpGet("Somar/{valor1}/{valor2}")]
        public async Task<ActionResult<Calculadora>> Somar(double valor1, double valor2)
        {
            var somar = await _calculadoraInterface.Somar(valor1, valor2);
            return Ok(somar);
        }

        [HttpGet("Subtrair/{valor1}/{valor2}")]
        public async Task<ActionResult<Calculadora>> Subtrair(double valor1, double valor2)
        {
            var somar = await _calculadoraInterface.Subtrair(valor1, valor2);
            return Ok(somar);
        }

        [HttpGet("Multiplicacao/{valor1}/{valor2}")]
        public async Task<ActionResult<Calculadora>> Multiplicacao(double valor1, double valor2)
        {
            var somar = await _calculadoraInterface.Multiplicacao(valor1, valor2);
            return Ok(somar);
        }

        [HttpGet("Divisao/{valor1}/{valor2}")]
        public async Task<ActionResult<Calculadora>> Divisao(double valor1, double valor2)
        {
            var somar = await _calculadoraInterface.Divisao(valor1, valor2);
            return Ok(somar);
        }

        [HttpGet("Ponteciacao/{valor1}/{valor2}")]
        public async Task<ActionResult<Calculadora>> Ponteciacao(double valor1, double valor2)
        {
            var somar = await _calculadoraInterface.Potenciacao(valor1, valor2);
            return Ok(somar);
        }


    }
}
