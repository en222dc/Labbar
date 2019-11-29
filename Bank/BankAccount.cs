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
        public decimal Credit { get; protected set; }
        public decimal TransactionFee { get; protected set; }
        //skapat properties

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
            //metod för insättning
        }

        public virtual bool Withdrawal(decimal withdraw)
        {
            return(true); 
            //metod för uttag
        }

        public decimal AccountBalance()
        {
            return Balance;
            //gav namnet AccountBalance eftersom Balance var upptaget av en property.
        }
    }
}
