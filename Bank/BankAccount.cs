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
        //skapat properties

        public void Deposit()
        {
            //metod för insättning
        }

        public virtual bool Withdrawal()
        {
            //metod för uttag
            //returvärde ska vara bool - inte "void"
            return(true); 
            //ska stå något annat i (true)
        }

        public virtual void AccountBalance()
        {
            //metod för uträkning av saldo+ev kredit
            //gav namnet eftersom Balance var upptaget av en property, men det kanske går att göra annorlunda?
        }
    }
}
