using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    public interface IAccount
    {
        public double ValorEntrada { get; set; }

        public double ValorSaida { get; set; }
        double Saldo();
    }
}
