using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    class Operations
    {
        public double ValorEntrada;
        public double ValorSaida;

        public void Deposit()
        {
            Console.WriteLine("Informe o valor a ser depositado");
            ValorEntrada = double.Parse(Console.ReadLine());
            
        }

        public void Withdraw()
        {
            Console.WriteLine("Informe o valor a ser sacado");
            ValorSaida = double.Parse(Console.ReadLine());

        }
    }   
}
