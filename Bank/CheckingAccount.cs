using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class CheckingAccount : BankAccount
    {
        public CheckingAccount(decimal c)
        {
            Credit = c;
            AccountType = "Lönekonto";
        }

        public override bool Withdrawal(decimal withdraw)
        {
            decimal amountAvaliable = Balance + Credit;

            if(amountAvaliable >= withdraw)
            {
                Balance -= withdraw;
                return true;
            }
            return false;
        }

        public override decimal GetBalance()
        {
            return Balance + Credit;
        }

    }
}
