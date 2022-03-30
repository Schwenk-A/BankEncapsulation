using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {

        private double Balance = 0;

        public double Deposit(double amountDeposit)
        {
           return Balance += amountDeposit;
        }

        public double GetBalance()
        {
            return Balance;
        }




    }
}
