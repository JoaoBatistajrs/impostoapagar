using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    public class Taxes
    {
        public double Tax;
        public double ImpostoAPagar;

        public void Taxation()
        {
            var SaldoConta = new AccountBalance();
            SaldoConta.Balance();
            
            Tax = SaldoConta.SaldoValor;

            Console.WriteLine("O saldo da sua conta é de: " + "R$" + Tax.ToString("N2"));
            {
                if (Tax <= 900)
                    ImpostoAPagar = (Tax * 0.02);

                if (Tax > 900 && Tax <= 2999)
                    ImpostoAPagar = (Tax * 0.025);

                if (Tax > 2999 && Tax <= 6999)
                    ImpostoAPagar = (Tax * 0.028);

                if (Tax > 6999)
                    ImpostoAPagar = (Tax * 0.3);
            }
          
            Console.WriteLine("O valor a ser pago de impostos é: " +"R$"+ ImpostoAPagar.ToString("N2"));
        }
        
    }
}
