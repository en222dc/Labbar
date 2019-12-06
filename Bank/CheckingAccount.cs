using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class CheckingAccount : BankAccount
    {
        public decimal Credit { get; protected set; }

        public CheckingAccount(decimal c)
        {
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

        public decimal GetCredit() //försöker fixa en metod som kan skicka credit till BankAccount
        {
            return Credit;
        }
    }
}
