using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        public int CellPhone { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Address { get; set; }

        private BankAccount BankAccount { get; set; }


        // Skapar properties som skall lagras i klassen Customer. (Personuppgifter).
    }

    //Customer customer = new Customer()
    //{
    //    FirstName = "",
    //    LastName = "",
    //    Address = "",
    //    CellPhone = ;
    //};
}
