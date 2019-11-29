using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class RetirementAccount : BankAccount
    {
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
            decimal fee = CalcTransactionFee(withdraw);
            //Skapat en variabel för uttagsavgiften

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
