using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B
{// string Name – Namn ska vara Varg, Fladdermus, Delfin, Örn, Häst och några till om du vill.

    class Animal
    {
        private string name;
        public string AnimalBehaviorDay { get; set; }
        public string AnimalBehaviorNight { get; set; }
        public bool Nocturnal { get; set; }
       
        public string Name {
            get {return name; }
            set
            {
                Console.WriteLine(name);
                
                if (value == "Varg" || value == "Fladdermus" || value == "Delfin" || value == "Örn" || value == "Häst")
                {
                    name = value;
                }
                else
                {
                    name = "No Name";
                }
                     } }
        public Animal(string _name, bool _nocturnal, string _animalBehaviorDay,string _animalBehaviorNight)
        {
            Name = _name;
            Nocturnal = _nocturnal;
            AnimalBehaviorDay = _animalBehaviorDay;
            AnimalBehaviorNight = _animalBehaviorNight;
        }
        
    }
}
