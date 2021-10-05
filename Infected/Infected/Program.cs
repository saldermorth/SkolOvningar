using System;
using System.Collections.Generic;

namespace Infected
{
    class Program
    {
        static void Main(string[] args)
        {
            int infected = 0;
            int immun = 0;
            List<Person> persons = new List<Person>();


            for (int i = 0; i < 49; i++)// skapar 49 st personer ej smittade, ej immuna,
            {
                Person test = new Person(false, 0 , false);
                persons.Add(test);
            }

            Person patientZero = new Person(true, 1, false); // skapar en smittad person.
            persons.Add(patientZero);
            for (int j = 0; j < 10; j++) //Timmar
            {
                foreach (var item in persons) //infected counter
                {
                    if (item.smittad == true && infected < 49)
                    {
                        infected++;
                    }
                }
                
                int newInfected = infected * 2;
                if (newInfected > 49) // new gets infected
                {
                    newInfected = 49;
                }

                for (int i = 0; i < newInfected; i++)
                {
                    if (persons[i].immun == false)
                    {
                        persons[i].smittad = true;
                    }

                }

                foreach (var item in persons)// immun
                {
                    if (item.smittadNär > 4)
                    {
                        item.immun = true;
                        item.smittad = false;
                        if (infected>0)
                        {
                            infected--;
                        }
                        
                        if (immun< 50)
                        {
                            immun++;
                        }
                       
                    }
                }
                foreach (var item in persons)
                {
                    if (item.smittad == true)
                    {
                        item.smittadNär++;
                    }
                }
                
                Console.WriteLine($"Immuna : {immun}  | Infected : {infected} ");
            }
            

            Console.ReadLine();
        }
    }
}
