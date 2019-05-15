using System;

namespace CalculaJuros.Services
{
    public class HelpersService
    {
        public static decimal TruncateDecimal2(decimal valor)
        {
            try
            {
                return Math.Truncate(100 * valor) / 100;
            }
            catch
            {
                return Math.Round(valor, 2);
            }
        }
    }
}
