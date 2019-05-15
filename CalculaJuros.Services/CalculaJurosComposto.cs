using CalculaJuros.Models;
using System;

namespace CalculaJuros.Services
{
    public class CalculaJurosComposto : ICalculaJurosService
    {
        /// <summary>
        /// VF = VI x (1  + taxa)^tempo
        ///Fórmula do montante em juros compostos
        ///Onde:
        ///VF é o valor final obtido na aplicação, ou seja, o saldo após a aplicação do juros;
        ///taxa é a taxa de juros aplicada, em porcentagem;
        ///VI é o capital ou valor inicial aplicado;
        ///tempo é o tempo total da aplicação.
        /// </summary>
        /// <param name="calcularJuros"></param>
        /// <returns>Valor Final</returns>
        public decimal CalculaJuros(CalcularJuros calcularJuros)
        {
            

            double taxa = 0.01;
            decimal valorFinal = Convert.ToDecimal(calcularJuros.ValorInicial * Math.Pow(1 + taxa, calcularJuros.Tempo));

            return HelpersService.TruncateDecimal2(valorFinal);
        }       
    }
}
