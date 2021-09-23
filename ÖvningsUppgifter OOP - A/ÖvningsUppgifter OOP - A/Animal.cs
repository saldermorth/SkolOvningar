using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifter_OOP___A
{
    public class Animal
    {   
        public string Type { get; set; }
        public string Name { get; set; }
        public int YearBorn { get; set; }
        public int Age { get; set; }
        public int NumbersOfLegs { get; set; }
        public bool Fast { get; set; }
        public Animal(string _type, string _name, int _yearBorn, int _age, int _numberOfLegs, bool _fast)
        {
            Type = _type;
            Name = _name;
            YearBorn = _yearBorn;
            Age = _age;
            NumbersOfLegs = _numberOfLegs;
            Fast = _fast;
        }
        public string IsFast()
        {
            if (Fast)
            {
                return "Fast";
            }
            else
            {
                return "Slow";
            }
        }


    }
}
