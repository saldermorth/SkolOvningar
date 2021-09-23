using System;

namespace ÖvningsUppgifter_OOP___A
{

    /*Skapa en klass, som innehåller följande properties
    - Djursort (string)
    - Namn (string)
    - Födelseår (int)
    - Ålder (int)
    - Antal ben (int)
    - Snabb (bool)
    - (alla namn ska vara på engelska)
    
       Utgå från exemplet med PersonStory och skapa en saga:
      Det var en gång en <ålder> år gammal <djursort> som hette
      <namn>. En dag var <namn> ute på en promenade I skogen, och
      mötte en stor varg. Vargen bet av ett ben. <namn> sprang <snabbt
      eller långsamt om snabb=true eller false> hem på sina <antalben –1>. Så var sagan slut.
    OOP : A-a
     Skapa en klass, som innehåller följande properties
     - Djursort (string)
     - Namn (string)
     - Födelseår (int)
     - Ålder (int)
     - Antal ben (int)
     - Snabb (bool)
     - (alla namn ska vara på engelska)
     Utgå från exemplet med PersonStory och skapa en saga:
     Det var en gång en <ålder> år gammal <djursort> som hette
     <namn>. En dag var <namn> ute på en promenade I skogen, och
     mötte en stor varg. Vargen bet av ett ben. <namn> sprang <snabbt
     eller långsamt om snabb=true eller false> hem på sina <antalben –1>. Så var sagan slut. 
    OOP: A-b
     - Sagan ska byggas av en separat metod. 
    - Sagan ska skrivas ut av en separat metod. 
    - Ålder ska räknas ut av en separat metod
     - Antal ben – 1 ska byggas av en separat metod
     - Djuret ska få sina properties I en separat metod
     - Main-metoden ska se ut så här enbart. static void Main(string[] args)
     {
     TellStory();
     }*/
    class Program
    {
        static void Main(string[] args)
        {

            TellStory();
            

            Console.ReadKey();
        }
        public static void TellStory()
        {
            Animal bobbY = new Animal();
            CreateObject(bobbY);
            GetAge(bobbY);
            string S = StringMaker(bobbY);
            PrintStory(S);

        }
        public static Animal CreateObject(Animal a)
        {
            a.YearBorn = 2017;
            a.Age = GetAge(a);             
            a.Name = "Bobby";
            a.Type = "Dog";
            a.NumbersOfLegs = 4;
            a.NumbersOfLegs = NumLegs(a);
            a.Fast = true;
            
            return a;

        }
        public static string StringMaker(Animal a)
        {
            string K = FastOrNot(a.Fast);
            string S = $"Det var en gång en {a.Age} år gammal {a.Type} som hette {a.Name}. \n En dag var {a.Name} ute på en promenade I skogen, och mötte en stor varg. \nVargen bet av ett ben. {a.Name} sprang {K} hem på sina {a.NumbersOfLegs} ben.Så var sagan slut.";
            return S;
        }
        public static int GetAge(Animal a)
        {
            int age = DateTime.Now.Year - a.YearBorn;
            return age;
        }
        public static void PrintStory(string s)
        {
            Console.WriteLine(s);
        }
        public static int NumLegs(Animal a)
        {
            int num = a.NumbersOfLegs - 1;
            return num;
        }
        public static string FastOrNot(bool b)
        {
            string speed;
            if (b)
            {
                speed = "snabbt";
            }
            else
            {
                speed = "långsamt";
            }
            return speed;
        }
    }
}
