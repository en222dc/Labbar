using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        private string CellPhone { get; set; } 
        private string FirstName { get; set; }
        private string LastName { get; set; } 
        private string Address { get; set; }
        // Skapar properties som skall lagras i klassen Customer. (Personuppgifter).

        public List<BankAccount> BankAccounts { get; protected set; } = new List<BankAccount>();
        //Lista för de olika konton som kunden har.

        public Customer(string cellPhone, string firstName, string lastName, string address)
        {
            CellPhone = cellPhone;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            //länkat Properties med parametrar
        }
    }
}
