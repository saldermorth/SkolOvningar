using System;

namespace ÖvningLoopar
{
    class Program
    {
      
        static void Main(string[] args)

        {

            //Övning Loopar V.2

            /*12. Du har talen 265-290. Summera alla jämna tal och ta sedan fram
                medelvärdet. Skriv ut summan till skärmen.*/


            //int j = 290;
            //int counter = 0;
            //int numbers = 0;
            //int result = 0;

            //for (int i = 265; i < j; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        numbers = numbers + i;
            //        counter++;

            //    }
            //}

            //result = numbers / counter;

            //Console.WriteLine(result);
            //Console.ReadKey();

            /*11. Hur många tal mellan 1-1000 är jämt delbara med 17? Skriv ut antalet till
                skärmen. */

            //int counter = 0;

            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i%17 == 0)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine($"{counter} st tal är delbara med 17. Mellan 1 och 1000" );

            /*10. Skapa ett program där användaren skall logga in. 
             Ta emot inmatade värden i variabler. 
             a. Skapa en konstant som innehåller användarnamn. Sätt värdet på den till abc123
             b. Skapa en konstant som innehåller lösenord. Sätt värdet på den till password
             c. Skriv ett meddelande till användaren och be denne att ange användarnamn
             d. Skriv ett meddelande till användaren och be denne att ange lösenord
             e. Om användaren anger ett riktigt användarnamn och lösenord, visa ett
                meddelande som säger- Du är inloggad. Avsluta programmet. 
             f. Om användaren anger felaktiga uppgifter , skriv ett meddelande på
              skärmen och tala om vad som var felaktigt. Fråga om användaren vill försöka
                igen(J/N). Om svaret är J skall inloggningen återupprepas.*/
            //const string userName = "abc123";
            //const string password = "password";
            //bool exitLoop = true; 
            //do
            //{
            //    Console.WriteLine("Mata in username");
            //    string inputUsername = Console.ReadLine();

            //    Console.WriteLine("Mata in password");
            //    string inputPassword = Console.ReadLine();

            //    if (userName == inputUsername && password == inputPassword)
            //    {
            //        Console.WriteLine("Du är inloggad");
            //        Environment.Exit(1);
            //    }
            //    else
            //    {

            //        Console.WriteLine("Vill du försöka igen?");
            //        Console.WriteLine("J/N ?");
            //        string tryAgain = Console.ReadLine();
            //        if (tryAgain == "J")
            //        {
            //            continue;
            //        }
            //        else if (tryAgain == "N")
            //        {
            //            Environment.Exit(1);
            //        }
            //        else
            //        {
            //            Environment.Exit(1);
            //        }
            //    }
            //} while (!exitLoop);

            /*9. Skapa ett program där användaren skall mata in kontaktuppgifter. Ta emot
        alla värden i variabler
        a. Be användaren mata in sitt namn, gatuadress, postnummer och postort.

        b. Kontrollera att alla uppgifter är ifyllda. Är dom det skall ett meddelande
        visas för användaren som säger- Alla uppgifter ifyllda. Programmet avslutas sedan. 

        c. Om inte alla uppgifter är ifyllda skall man börja om med steg a-d. 
        Kontrollera för varje värde om just det värdet är ifyllt. 
        Programmet skall inte be  användaren mata in ett värde som redan är inmatat.*/
            //bool alltIfyllt = false;
            //string[] visningsinfo = new string[] { "Namn", "Gatuadress", "PostNummer", "Postort" };
            //string[] inmatat = new string[4];



            //for (int i = 0; i < visningsinfo.Length; i++)
            //{
            //    Console.WriteLine("Skriv in " + visningsinfo[i] + ":");

            //    inmatat[i] = Console.ReadLine();
            //}

            //do
            //{
            //    for (int i = 0; i < inmatat.Length; i++)
            //    {
            //        if (inmatat[i] == null || inmatat[i] == "")
            //        {
            //            switch (visningsinfo[i])
            //            {
            //                case "Namn":
            //                    Console.WriteLine("Skriv in : Namn");
            //                    alltIfyllt = false;
            //                    break;
            //                case "Gatuadress":
            //                    Console.WriteLine("Skriv in : Gatuadress");
            //                    inmatat[i] = Console.ReadLine();
            //                    alltIfyllt = false;
            //                    break;
            //                case "PostNummer":
            //                    Console.WriteLine("Skriv in : PostNummer");
            //                    alltIfyllt = false;
            //                    break;
            //                case "Postort":
            //                    Console.WriteLine("Skriv in : Postort");
            //                    alltIfyllt = false;
            //                    break;
            //                default:
            //                    break;
            //            }
            //        }
            //    }
            //} while (alltIfyllt);




            //for (int i = 0; i < inmatat.Length; i++)
            //{
            //    Console.WriteLine(inmatat[i]);
            //}




            /*8. Skapa ett program där användaren får mata in ett tal. 
            a. Låt sedan programmet kontrollera om värdet är mindre än 30. 

            b. Kontrollera att användaren matar in ett giltigt tal och inte andra tecken. 
            Ett tips är att använda int.TryParse metoden. Om det inte är ett tal meddela
            användaren –Du har matat in ett ogiltigt tal

            c. Är det större än 30 skriv ett meddelande- Du har matat in ett felaktigt tal

            d. Annars skriva ut alla siffor som är större än det inmatade talet men
            mindre eller lika med än 30. Lös detta med en for-loop.*/

            //{
            //    Console.WriteLine("Skriv en siffra!");
            //    string siffraSomString = Console.ReadLine();
            //    int siffraSomInt = Convert.ToInt32(siffraSomString);

            //    bool funkar = Int32.TryParse(siffraSomString, out siffraSomInt);
            //    Console.Clear();

            //    if (siffraSomInt < 30 && funkar)
            //    {
            //        for (int i = siffraSomInt; i <= 30; i++)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Fel inmatning");
            //    }


            //}



            /*7. Skapa ett program som skriver ut alla udda tal under 100. Ett tips är att
                använda operatorn % (modulus) . Detta räknar ut resten efter att två tal
                divideras tex 5 % 2 blir 1*/
            //for (int i = 0; i < 100; i++)
            //{

            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine("#" + i);
            //    }
            //}


            ///6. Skapa ett program där användaren skriver in ett tal. 
            //a. Skriv mata in ett tal på skärmen
            //b.Om det är högre än 10 får användaren ett meddelande som säger-Värdet
            //är för högt.Visa meddelandet-Mata in ett tal på skärmen. 
            //c.Om det är under 10 får användaren ett meddelande som säger-Värdet är
            //för lågt.Visa meddelandet-Mata in ett tal på skärmen.
            //d.När användaren matar in 10 avbryts programmet och användaren får
            //meddelandet – Du matade in rätt tal.
            //do
            //{
            //    Console.WriteLine("Mata in ett tal :");
            //    int tal1 = Convert.ToInt32(Console.ReadLine());
            //    if (tal1 > 10)
            //    {
            //        Console.WriteLine("Talet är för stort.");

            //    }
            //    else if (tal1 < 10)
            //    {
            //        Console.WriteLine("Talet är för litet");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Rätt tal!!");
            //        break;
            //    }
            //} while (true);



            //5. Skapa ett program där användaren får mata in ett tal. 
            //Låt sedan programmet
            // skriva ut alla siffor som är mindre än det inmatade talet men större än 0.
            //Lös detta med en loop.
            //
            //Console.WriteLine("Skriv in ett tal : ");
            //int tal1 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < tal1; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //

            //4. Be användaren mata in ett tal.
            //Spara värdet i en variabel.
            //Upprepa detta 10gånger.
            //För varje gång lägg till det inmatade värdet till variabelns värde.
            //När det är klart skriv ut-Summan av det du matat in är: summan
            //int tal1 = 0;
            //int j = 1;
            //for (int i = 0; i <= 9; i++)
            //{

            //    Console.WriteLine("Mata in  tal" + j);
            //    int temp = Convert.ToInt32(Console.ReadLine());
            //    j++;
            //    tal1 += temp;
            //}
            //Console.WriteLine($"Summan är {tal1}");
            //Console.ReadKey();

            // 3.Skapa ett program där användaren
            //a.Får mata in två tal.
            //b.Skriv sedan till skärmen summan av de två talen.
            //c.Skriv sedan en fråga-Vill du fortsätta(J/ N)?.
            //d.Svarar användaren J återupprepas punkt a-c
            //e.Svarar användaren N avbryts programmet
            //bool loop = true;
            //do
            //{

            //    Console.WriteLine("Mata in ett tal");
            //    int tal1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Mata in ett tal");
            //    int tal2 = Convert.ToInt32(Console.ReadLine());
            //    Console.Clear();
            //    Console.WriteLine(tal1 + tal2);

            //    Console.WriteLine("Vill du fortsätta?");
            //    Console.WriteLine("------J/N---------");
            //    char svar = Convert.ToChar(Console.ReadLine());
            //    switch (svar)
            //    {
            //        case 'N':
            //            loop = false;
            //            break;
            //        case 'J':
            //            loop = true;
            //            break;
            //        default:
            //            break;
            //    }
            //} while (loop);


            //    2.Skapa ett program där användaren får mata in två tal. Låt sedan programmet
            //skriva ut alla tal som finns mellan dessa två tal på skärmen.Lös detta med en
            //for-loop.
            //Console.WriteLine("Skriv in ett tal :");
            //int tal1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Skriv in ett till tal :");
            //int tal2 = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //for (int i = tal1; i < tal2; i++)
            //{

            //        Console.WriteLine(i);


            //}
            //
            //  1.Skapa ett program som skriver ut talen 0 - 10 på skärmen. Lös detta med en
            //for-loop.
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}



        }
    }
}
