using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente 
{
    public class Account : IAccount
    {

        public double ValorEntrada { get ; set ; }
        public double ValorSaida { get; set; }

        public double Saldo()
        {

            if (ValorSaida > ValorEntrada)
                Console.WriteLine("O valor de Saída não pode ser maior do que as estradas.");
            
                return ValorEntrada - ValorSaida;
        }

    }
}
