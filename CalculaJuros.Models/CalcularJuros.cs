using System;

namespace CalculaJuros.Models
{
    public class CalcularJuros
    {
        public double ValorInicial { get; set; }
        public double Taxa { get; set; }
        public int Tempo { get; set; }

        
        public CalcularJuros(double valorInicial, int tempo)
        {
            ValorInicial = valorInicial;
            Tempo = tempo;
            Taxa = 0.01;
        }
    }
}
