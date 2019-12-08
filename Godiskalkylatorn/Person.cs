using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godiskalkylatorn
{
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Candies { get; set; }

        public Person()
        {
            Name = Name;
            Age = Age;
            Candies = Candies;
        }

        public override string ToString()
        {
            return $"{Name} ({Age} år): --> {Candies} godisar."; 
        }

    }
}
