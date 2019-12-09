using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Godiskalkylatorn
{
    class CandyCalculator
    {
        public int NumberOfCandies { get; set; }

        private List<Person> candyEaters = new List<Person>();

        public CandyCalculator(int numberOfCandies)
        {
            NumberOfCandies = numberOfCandies;
        }
        public CandyCalculator()
        {
        }

        public void AddPerson(int age, string name)
        {
            Person newPerson = new Person()
            {
                Age = age,
                Name = name
            };
            candyEaters.Add(newPerson);
        }


        public List<Person> DivideCandy()
        {
            while (NumberOfCandies != 0)
            {
                foreach (Person person in candyEaters)
                {
                    person.Candies++;
                    NumberOfCandies--;
                    if (NumberOfCandies == 0)
                        break;
                }
            }
            return candyEaters;
        }

        public List<Person> DivideCandyByAge()
        {
            while (NumberOfCandies != 0)
            {
                foreach (Person person in candyEaters.OrderBy(x => x.Age))
                {
                    person.Candies++;
                    NumberOfCandies--;
                    if (NumberOfCandies == 0)
                        break;
                }
            }
            return candyEaters.OrderBy(x => x.Age).ToList();
        }

        public List<Person> DivideCandyByName()
        {
            while (NumberOfCandies != 0)
            {
                foreach (Person person in candyEaters.OrderBy(x => x.Name))
                {
                    person.Candies++;
                    NumberOfCandies--;
                    if (NumberOfCandies == 0)
                        break;
                }
            }
            return candyEaters.OrderBy(x => x.Name).ToList();
        }

        public void GetPeople()
        {
           if (File.Exists("candyEaters.bin"))
                candyEaters = (List<Person>)FileOperations.Deserialize("candyEaters.bin");
        }

        public void ClearCandy()
        {
            foreach (Person person in candyEaters)
                person.Candies = 0;
        }

        public void SaveToFile()
        {
            FileOperations.Serialize(candyEaters, "candyEaters.bin");
        }

    }

}
