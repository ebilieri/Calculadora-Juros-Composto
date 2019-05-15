using CalculaJuros.Models;
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
        public IActionResult Get(double valorInicial, int meses)
        {
            try
            {
                var calculaJuros = new CalcularJuros(valorInicial, meses);

                decimal valorFinal = _calculaJurosService.CalculaJuros(calculaJuros);
                return Ok(valorFinal.ToString("N2"));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}
