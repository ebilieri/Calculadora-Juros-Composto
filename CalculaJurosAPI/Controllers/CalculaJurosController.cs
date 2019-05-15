using CalculaJuros.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculaJurosAPI.Controllers
{
    [Route("calculajuros")]
    public class CalculaJurosController : Controller
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosController(ICalculaJurosService calculaJurosService)
        {
            _calculaJurosService = calculaJurosService;
        }

        [HttpGet]
        public IActionResult Get(decimal valorInicial, int meses)

        {
            try
            {
                decimal valorFinal = _calculaJurosService.CalculaJuros(Convert.ToDouble (valorInicial), meses);
                return Ok(valorFinal.ToString("N2"));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}
