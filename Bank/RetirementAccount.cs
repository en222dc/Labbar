using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class RetirementAccount : BankAccount
    {
        public decimal TransactionFee { get; protected set; }

        decimal fee;

        public RetirementAccount()
        {
            AccountType = "Pensionspar";
            TransactionFee = 0.10M;
            //Uttagsavgiften är på 10% av uttagssumman
        }

        private decimal CalcTransactionFee(decimal withdraw)
        {
            return TransactionFee * withdraw;
        }

        public override bool Withdrawal(decimal withdraw)
        {
            fee = CalcTransactionFee(withdraw);

            if(Balance > (withdraw + fee))
            {
                Balance -= (withdraw + fee);
                return true;
                //om saldot är större än utaget+avgiften så ska kunden kunna göra uttaget.
            }
            return false;
        }
    }
}
