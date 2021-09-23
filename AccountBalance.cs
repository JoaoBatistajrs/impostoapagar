using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    public class AccountBalance
    {

        public double SaldoValor;
        public void Balance()
        {
            var ContaBanco = new Account();

            ContaBanco.Saldo();
            {
                var Operacoes = new Operations();
                {
                    Operacoes.Deposit();
                    Operacoes.Withdraw();

                }
                ContaBanco.ValorEntrada = Operacoes.ValorEntrada;
                ContaBanco.ValorSaida = Operacoes.ValorSaida;

            }
            SaldoValor = ContaBanco.Saldo();

        } 
    }
}
