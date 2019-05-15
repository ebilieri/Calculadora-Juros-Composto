using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaJuros.Services
{
    public class CalculaJurosComposto : ICalculaJurosService
    {

        public decimal CalculaJuros(double valorInicial, int tempo)
        {

            // VF = VI x (1  + taxa)^tempo

            //Fórmula do montante em juros compostos
            //Onde:
            //VF é o valor final obtido na aplicação, ou seja, o saldo após a aplicação do juros;
            //taxa é a taxa de juros aplicada, em porcentagem;
            //VI é o capital ou valor inicial aplicado;
            //tempo é o tempo total da aplicação.

            double taxa = 0.01;
            double valorFinal = Math.Round(Convert.ToDouble(valorInicial) * Math.Pow(1 + taxa, tempo), 2);

            return Convert.ToDecimal(valorFinal);
        }
    }
}
