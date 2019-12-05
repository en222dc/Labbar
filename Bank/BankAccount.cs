using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class BankAccount
    {
        public string AccountType { get; set; }
        public decimal Balance { get; protected set; }
        //skapat properties

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
            //metod för insättning
        }

        public override string ToString()
        {
            return $"{AccountType} {Balance:c}"; //Måste få in så att krediten räknas med i CheckingAccount också...
        }

        public virtual bool Withdrawal(decimal withdraw)
        {
            if (withdraw > Balance)
            {
                return false;
            }

            Balance -= withdraw;
            return(true); 
            //metod för uttag
        }

        public virtual decimal GetBalance()
        {
            return Balance;
            //gav namnet GetBalance eftersom Balance var upptaget av en property.
        }
    }
}
