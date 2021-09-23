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
      eller långsamt om snabb=true eller false> hem på sina <antalben –1>. Så var sagan slut.*/
    class Program
    {
        static void Main(string[] args)
        {
           Animal bobbY = new Animal("Dog","Bobby", 2015, 4,4, true);

            Console.WriteLine($@"Det var en gång en {bobbY.Age} år gammal {bobbY.Type} som hette {bobbY.Name}. En dag var {bobbY.Name} ute på en promenade I skogen, och mötte en stor varg. Vargen bet av ett ben. {bobbY.Name} sprang {bobbY.IsFast()} hem på sina {bobbY.NumbersOfLegs - 1}.Så var sagan slut.");

            Console.ReadKey();
        }
    }
}
