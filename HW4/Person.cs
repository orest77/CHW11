using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name { get { return name; } }
        public DateTime BirthYear { get { return birthYear; } }

        public Person()
        {

        }
        public Person(string _name, DateTime _birthyear)
        {
            this.name = _name;
            this.birthYear = _birthyear;
        }

        public int Age()
        {
            return DateTime.Now.Year - BirthYear.Year;
        }
        public void Input()
        {
            Console.Write("Input person name: ");
            name = Console.ReadLine();
            Console.Write("Input person birthday (yyyy) : ");
            birthYear = DateTime.ParseExact(Console.ReadLine(), "yyyy",null);

        }

        public void ChangeName(string n)
        {
            this.name = n;
        }
        public override string ToString()
        {
            return $"{name} + {Age()}".ToString();
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator ==(Person first, Person second)
        {
            return (first.Name == second.Name);
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }
    }
}
