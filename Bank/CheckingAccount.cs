using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class CheckingAccount : BankAccount
    {
        public CheckingAccount()
        {
            AccountType = "Lönekonto";
            Credit = 1000;
            //krediten ska flyttas sen, tänker mig att det borde vara i xaml-koden istället...
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
    }
}
