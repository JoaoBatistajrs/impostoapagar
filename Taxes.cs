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
        public double impostoapagar;

        public void Taxation()
        {
            var SaldoConta = new AccountBalance();
            SaldoConta.Balance();
            
            Tax = SaldoConta.SaldoValor;

            Console.WriteLine(Tax);
            {
                if (Tax <= 900) { impostoapagar = (Tax * 2); }
                   

                else if (Tax > 900 && Tax <= 2999) { impostoapagar = (Tax * 0.025); }
                    

                else if (Tax > 2999 && Tax <= 6999) { impostoapagar = (Tax * 0.028); }


                impostoapagar = (Tax * 0.3);

            Console.WriteLine(impostoapagar);
            }
        }
        
    }
}
