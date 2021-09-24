using System;
using System.Collections.Generic;

namespace OOP_B
{ /*
   }
      OOP : B
      Skapa ett objekt som har följande egenskaper: ◦ string Name – Namn ska vara Varg, Fladdermus, Delfin, Örn, Häst
      och några till om du vill. ◦ bool Nocturnal – Nattdjur, sant eller falskt
      Skapa minst en instans av varje djur, gärna fler, och stoppa i listan
      forrest. ◦ Välj två knappar, som ska vara dag och natt. ◦ Trycker du på nattknappen ska det stå följande om vargen och
      fladdermusen (och andra nattdjur): ◦ “Vargen smyger omkring och letar sitt byte” och “Fladdermusen
      flyger runt bland träden I jakt på mat”. ◦ De djur som inte är nocturnal beskrivs med: Hästen sover, Delfinen sover osv. 
    ◦ Trycker du på dagknappen så ska det omvända ske, Vargen och
      Fladdermusen sover, och denadra djuren gör något, t ex letar mat
      eller springer genom skogen o s v.
   */
    class Program
    {
        static void Main(string[] args)

        {
            bool selection = true;
            string dayOrNight;

            // string Name – Namn ska vara Varg, Fladdermus, Delfin, Örn, Häst och några till om du vill.
            List<Animal> forest = new List<Animal>();

            forest.Add(new Animal("Varg", true,"sleeps", "roams tha plaines."));
            forest.Add(new Animal("Fladdermus", true,"sleeps", "turns to dracula."));
            forest.Add(new Animal("Delfin", false,"swimms around", "sleeps"));
            forest.Add(new Animal("Örn", false, "soars", "sleeps in the nest"));
            forest.Add(new Animal("Häst", false,"jumps things", "sleeps standing up"));

            Console.WriteLine("Write Day or Night");
            dayOrNight = Console.ReadLine();
            dayOrNight = dayOrNight.ToLower();
            if (dayOrNight == "day")
            {
                selection = false;
            }
            else if(dayOrNight == "night")
            {
                selection = true;
            }
            else
            {
                Console.WriteLine("Incorrect choice");
                Environment.Exit(1);
            }

            if (!selection)
            {
                foreach (var Animal in forest)
                {
                    if (Animal.Nocturnal == true)
                    {
                        Console.WriteLine($"{Animal.Name} {Animal.AnimalBehaviorDay}");
                    } 
                    if (Animal.Nocturnal == false)
                    {
                        Console.WriteLine($"{Animal.Name} {Animal.AnimalBehaviorDay}");
                    }

                }
            }
            else
            {
                foreach (var Animal in forest)
                {
                    if (Animal.Nocturnal == true)
                    {
                        Console.WriteLine($"{Animal.Name} {Animal.AnimalBehaviorNight}");
                    }
                    if (Animal.Nocturnal == false)
                    {
                        Console.WriteLine($"{Animal.Name} {Animal.AnimalBehaviorNight}");
                    }

                }

            }
           
            

        }
    }
}
