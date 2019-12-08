using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; } 
        public string CellPhone { get; private set; } 
        // Skapar properties som skall lagras i klassen Customer. (Personuppgifter).

        public List<BankAccount> bankAccounts = new List<BankAccount>();
        //Lista för de olika konton som kunderna har.

        public Customer(string firstName, string lastName, string cellPhone)
        {
            FirstName = firstName;
            LastName = lastName;
            CellPhone = cellPhone;
            //länkat Properties med parametrar
        }

        public bool AddBankAccount(BankAccount bankAccount)
        {
            if (bankAccounts.Count < 6)
            {
                bankAccounts.Add(bankAccount);
                return true;
            }
            return false;
        }

        public override string ToString() // Magisk metod för att visa för och efternamn i combobox.
        {
            return $"{FirstName} {LastName}";
        }
    }
}
