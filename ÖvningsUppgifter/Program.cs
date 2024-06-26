﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ÖvningLoopar
{
    class Program
    {
        
        static void Main(string[] args)
        {

            /*Övningsuppgifter-Metoder
             1.Skapa ett program med en ny metod. Döp metoden till
             PrintMessage(). Den skall returnera texten – ”Hello World!”. 
            
            PrintMessage();

            static void PrintMessage()
            {
             Console.WriteLine("Hello World");
             }              
            
            
            2.Skapa en metod som heter ToPercentage. Användaren skall mata
             in ett decimaltal mellan 1 och 0. Metoden omvandlar talet till
             procent tex skall 0.5 bli 50%. 
            
            ToPercentage(0.5);

            static void ToPercentage(double d)
            {
                d = d * 100;
                Console.WriteLine($"{d}%");
            }
                       
                        
            3.Skapa ett program med en ny metod. Metoden skall ta emot två
             inparametrar av typen string och slå ihop dom till en sträng och
             returnera det nya värdet. Anropa den nya metoden från Main och
             skriv ut resultatet på skärmen. 
            
            string done = StringAdder("Hello", "Världen");

            Console.WriteLine(done);
            static string StringAdder(string a, string b)
            {
                string C = $"{a} / {b}";
                return C;
            }
                                 
            4.Skapa en metod som räknar ut hur mycket momsen blir på en viss
             summa. Summan skall vara en inparameter av typen int. Metoden
             skall returnera momsvärdet. 
            
            int exMoms = 125;
            double inkMoms = InkMoms(exMoms);
            Console.WriteLine($"Momsen på {exMoms}:-. \nÄr : "+inkMoms + ":-");

            static double InkMoms(int exMoms)
            {
                double inkMoms = exMoms * 0.125;
                return inkMoms;
            }
            
            
            5.Skapa ett program där användaren får en fråga om att mata in sin
             ålder. Skapa en metod som tar emot det inmatade värdet och
             kontrollerar om användaren är myndig dvs över 18 år. Metoden returnerar sant eller falskt. Anropa metoden och skriv ut
             på skärmen om användaren är myndig eller ej.
           
            int age = 0;
            Console.WriteLine("Vad är din ålder?");
            age = Convert.ToInt32(Console.ReadLine());
            bool offAgeBool = offAge(age);

            Console.WriteLine($"Är du myndig? :{offAgeBool}");

            static bool offAge(int age)
            {
                if (age >= 18)
                {
                    return true;
                }
                else if (age< 18)
                {
                    return false;
                }
                else
                {
                    return false;
                }

            }
            

            6.Du skall nu testa att anropa en metod från ytterligare en metod. Skapa först en metod som du döper till MaxVarde2()
            a. Metoden skall ta två heltal som inparametrar och returnera det värde som är störst. 

            b. Skapa även en metod som du döper till MaxVarde3() som fungerar på samma sätt men tar 3 heltal som inparametrar. 
            
            c. Skapa en metod som heter KontrolleraMaxVarde(). Den skall ha tre tal som inparametrar och returnera ett tal tillbaka. 
            Om någon av inparametrarna är 0 skall metoden MaxVarde2 anropas från denna metod och inparametrarna skickas vidare. 
            
            d. Om ingen av inparametrarna är 0 skall metoden MaxVarde3 anropas med de inparametrar som kommit in. 
            
            e. KontrolleraMaxVarde() skall returnera det värde från de andra metoderna som är störst. 
            
            int max = KontrolleraMaxVarde(0, 12, 11);
            Console.WriteLine(max);


            static int MaxVarde2(int a, int b)
            {
                if (a>b)
                {
                    return a;
                }
                else if (a<b)
                {
                    return b;
                }
                else if (a==b)
                {
                    Console.WriteLine("Talen är lika stora.");
                    return 0;
                }
                return 0;
            }
            static int MaxVarde3(int a, int b,int c)
            {
                int[] biggest = { a, b, c };
                
                int max = biggest.Max();
                return max;
            }
            static int KontrolleraMaxVarde(int a, int b ,int c)
            {
                int[] biggest = { a, b, c };
                List<int> biggestOfTwo = new List<int>();
                int sum = 0;

                for (int i = 0; i < biggest.Length; i++)
                {
                    if (biggest[i]!=0) 
                    {
                        biggestOfTwo.Add(biggest[i]);
                    }
                }
                if (biggestOfTwo.Count == 2)
                {
                    a = biggestOfTwo[0];
                    b = biggestOfTwo[1];

                    sum = MaxVarde2(a, b);
                }
                else
                {
                    a = biggestOfTwo[0];
                    b = biggestOfTwo[1];
                    c = biggestOfTwo[2];
                    sum =MaxVarde3(a,b,c);
                }

                
                
                return sum;
            }
            

            


            7.Skapa en metod som du döper till HittaLangstaOrdet. Metoden
             skall ta som inparameter en array med strängar. Metoden skall
             loopa igenom arrayen och returnera det längsta ordet. 
            

            string[] namn = { "Anna", "Berit", "Starfly", "Toothless" };

            string längst = HittaLängstaOrdet(namn);

            Console.WriteLine(längst);
            static string HittaLängstaOrdet(string[] a)
            {
                string maxLWord = "";
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.Length-1 ; j++)
                    {
                        if (a[j].Length < a[j+1].Length)
                        {
                            maxLWord = a[i];
                        }                       
                        
                    }                 

                }
                return maxLWord;

            }

            
            
            
            8.Skapa två metoder , en som heter sum() och en som heter
             multiply() . Dessa skall summera respektive multiplicera alla tal I en
             array av heltal.Till exempel , sum([1,2,3,4]) skall returnera 10, och
             multiply([1,2,3,4]) skall returna 24.
            
            int[] numbers = { 1, 2, 3, 4 };

            Console.WriteLine(sum(numbers));
            Console.WriteLine("_______");
            Console.WriteLine(add(numbers));


            static int sum(int[] a)
            {
                int sum = 0;
                foreach (int i in a)
                {
                    sum = sum + i;
                }
                return sum;
            }


            static int add(int[] a)
            {
                int sum = 0;
                for (int i = 0; i < a.Length-1; i++)
                {

                    if (i<1)
                    {
                        sum = (a[i] * a[i + 1]);
                    }
                    else
                    {
                        sum *= a[i + 1];
                    }
                    
                }
                return sum;
            }
            
            
            

             Lite svårare uppgifter:

             9.Skapa en metod som tar en bokstav och returnerar true om det är
             en vokal och false annars. 
            a, e, i, o, u, y, å, ä och ö.
            
            char a = 'k';

            bool isVoule = Vokal(a);
            Console.WriteLine(isVoule);


            static bool Vokal(char a)
            {
                if (a == 'a' || a== 'e' || a == 'i' || a == 'o' || a == 'u' || a == 'y' || a == 'å' || a == 'ä' || a == 'ö')
                {
                    return true;
                }
                return false;
            }
                        

             10.Skriv en metod som du döper till Translate() . Den skall översätta en text till "rövarspråket".
             Det betyder att dubbla varje konsonant och placera bokstaven ”o” mellan dessa konsonanter. 
             Till example , Translate("this is fun") skall returna strängen "tothohisos isos fofunon". Returnera inte
             värdet med return utan genom en referens inparameter. 
            
            string a = "this is fun";
            Translate(ref a);

            Console.WriteLine(a);

            static void Translate(ref string a)
            {
                char[] b = a.ToCharArray();
                List<char> k = new List<char>();
                bool one = false;
                

                for (int i = 0; i < b.Length; i++)
                {
                    
                        one = Vokal(b[i]);                        

                        if (one)
                        {
                            k.Add(b[i]);
                            k.Add('o');
                            k.Add(b[i]);                            
                        }
                        else
                        {
                            k.Add(b[i]);
                        }
                                                                
                }
                var myString = new string(k.ToArray());
                a = myString;
                
            }

            static bool Vokal(char a)
            {
                if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u' || a == 'y' || a == 'å' || a == 'ä' || a == 'ö' | a == ' ')
                {
                    return false;
                }
                return true;
            }

                       
            
             11.Skapa en void metod som du döper till ReferenceOut och tar emot
             två parametrar av typen int. Den ena skall skickas in som ref och
             den andra som out. Testa att anropa metoden och sätta om värdet
             på den båda variablerna inne i metoden. Vad är skillnaden mellan
             out och ref ? Hur fungerar det praktiskt när du anropar en metod?
            
            //Ref value = When we use REF, data can be passed bi-directionally. changes made in the method effects the variable in main for example.
            //Out value = When we use OUT data is passed only in a unidirectional way (from the called method to the caller method). Do not need to be initialized outside the method but in it.
            int a = 5;
            int b;
            ReferenceOut(ref a, out  b);

            Console.WriteLine(a+ " "+ b);
            static void ReferenceOut(ref int a, out int b)
            {
                a = a + 1;

                b = 1;
                b = b + 1;
            }
            
            
            


             När skall man använda out respektive ref i en metod?*/
            /*
             * Övningsuppgifter-Array
            1. Skapa ett program där användaren får upp ett antal frågor där den
            får mata in sitt förnamn, efternamn, adress, postort, telefon, email. Spara alla dessa värden i en array. Skriv sedan tillbaka en
            kontrollfråga på skärmen till användaren där du läser ut alla värden
            från arrayen. Du har matat in följande uppgifter……stämmer det?
            */
            //string[] info = { "1.Förnamn", "2.Efternamn", "3.Adress", "4.Postort", "5.Telefon", "6.Email" };
            //string[] infoInmatad = new string[6];
            //int counter = 0;

            //for (int i = 0; i < info.Length; i++)
            //{
            //    Console.WriteLine($"Var god mata in {info[i]}");
            //    infoInmatad[i] = Console.ReadLine();

            //}

            //foreach (var item in infoInmatad)
            //{

            //    Console.Write(info[counter] + " : ", -20);
            //    Console.WriteLine(item);
            //    counter++;
            //}

            /*
            2. Skapa ett program där användaren får upp fyra frågor om att mata
            in ett tal. Spara alla talen i en array. Loopa igenom arrayen och ta
            fram det tal som är störst. Skriv tillbaka resultatet på skärmen för
            användaren. 
            */
            //int[] numRecived = new int[4];
            //int j = 3;
            //for (int i = 0; i < 4; i++)
            //{

            //    Console.WriteLine("Mata in ett tal. " +j+ " till tal.");
            //    numRecived[i] = Convert.ToInt32(Console.ReadLine());
            //    j--;
            //}
            //Console.WriteLine("The biggest number is: ");
            //Console.WriteLine(numRecived.Max().ToString());

            /*
            3. Utöka uppgift 2 med en inledande fråga där användaren får ange
            hur många tal den vill mata in. Gör sedan samma sak för att ta fram
            det största talet. 
            */
            //Console.WriteLine("How many number you want to enter?");
            //int numOfNums = Convert.ToInt32(Console.ReadLine());
            //int[] numrecived = new int[numOfNums];
            //int j = numOfNums;

            //for (int i = 0 ; i < numOfNums; i++)
            //{

            //    Console.WriteLine("mata in ett tal. " +j+ " till tal.");
            //    numrecived[i] = Convert.ToInt32(Console.ReadLine());
            //    j--;
            //}
            //Console.WriteLine ("the biggest number is: ");
            //Console.WriteLine(numrecived.Max().ToString());
            /*
            4. Skapa en array av 5 heltal och fyll den med värden. Byt ut alla
            udda tal i arrayen mot talet 0. Skriv sedan efteråt ut innehållet i hela
            arrayen till skärmen. 
            */
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int numLength = num.Length;

            //for (int i = 0; i < num.Length; i++)
            //{

            //    if (num[i] % 2 != 0)
            //    {
            //        num[i] = 0;
            //    }
            //}

            //foreach (int item in num)
            //{
            //    num[item] = +2;
            //    Console.WriteLine(item);
            //}


            /*
            5. Skapa en array som skall innehålla temperaturmätningar. Användaren får först upp en fråga om hur många mätningar som
            skall registreras. Sedan får denne ange värde för varje mätning. Detta skall vara decimaltal. Skriv sedan ut alla mätningar och
            avsluta med att ange en max och en medeltemperatur.
            */
            //Console.WriteLine("Ange antal mätningar : ");
            //int numcount = Convert.ToInt32(Console.ReadLine());
            //decimal[] temps = new decimal[numcount];

            //for (int i = 0; i < numcount; i++)
            //{
            //    Console.WriteLine("Ange temp :");
            //    temps[i] = Convert.ToDecimal(Console.ReadLine());
            //}

            //Console.Clear();

            //foreach (decimal item in temps)
            //{
            //    Console.WriteLine(item+" ");
            //}

            //Console.WriteLine("\nMin :"+temps.Min());
            //Console.WriteLine("Max :"+temps.Max());

            //foreach (decimal item in temps)
            //{
            //    Console.WriteLine("Ange temp :");
            //    item = 1;
            //}

            /*
            6. Utöka uppgift 5 med att även ange mätdatum för varje mätvärde. Skriv sedan ut varje mätvärde på samma sätt men tillsammans med
            mätdatum. 
            */
            // Console.WriteLine("Ange antal mätningar : ");
            //int numcount = Convert.ToInt32(Console.ReadLine());
            //decimal[] temps = new decimal[numcount];
            //DateTime[] noted = new DateTime[numcount];

            //for (int i = 0; i < numcount; i++)
            //{
            //    Console.WriteLine("Ange temp :");
            //    temps[i] = Convert.ToDecimal(Console.ReadLine());
            //    noted[i] = DateTime.Now;
            //}

            //Console.Clear();
            //for (int i = 0; i < numcount; i++)
            //{
            //    Console.WriteLine(temps[i] + "  Recorded at  :" + noted[i].ToShortTimeString() );

            //}

            //foreach (decimal item in temps)
            //{
            //    Console.WriteLine(item+" ");
            //    Console.WriteLine();

            //}

            //Console.WriteLine("\nMin :"+temps.Min());
            //Console.WriteLine("Max :"+temps.Max());


            /*
            7. Skapa ett program där användaren får mata in en inköpslista. Börja med att fråga användaren hur många varor den skall ha på sin
            lista. Gör en loop som gås igenom det antal gånger som användaren
            angivit. Inne i loopen skall tre frågor anges- Vilken vara som
            användaren vill lägga till- Vilket pris varan har – Vilket
            produktnummer. Spara alla dessa värden i en array. Loopa sedan
            igenom arrayen och skriv ut alla varor som användaren har angivit
            med alla uppgifter på skärmen. 
            
            8. Skapa ett program där användaren skall mata in kontaktuppgifter. Ta emot alla värden i variabler
            a. Be användaren mata in sitt namn, gatuadress, postnummer, postort. b. Fråga om användaren vill mata in en ny person(J/N)
            c. Om J återupprepa steg a-e. Detta kan göras max 5 gånger. d. Svarar användaren N eller om 5 personer matats in- e. Skriv ut alla personers uppgifter på skärmen.
            Lite svårare uppgifter:
            
            9. Skapa ett program där användaren måste mata in 10 tal. Programmet skall bara spara tal som har ett värde som är mindre än
            30, annars anses det som felaktigt tal. När användaren matat in 10
            riktiga tal skrivs dessa ut på en lista på skärmen
            
            10. Skapa ett program där användaren måste mata in 5 ord. Ta fram
            det längsta ordet d vs det med flest bokstäver i och skriv ut det på
            skärmen
            
            11.Skapa ett program där användaren skriver in ett tal. Spara alla
            felaktiga inmatningar i en array. a. Skriv mata in ett tal på skärmen
            b. Om det är högre än 10 får användaren ett meddelande som
            säger-Värdet är för högt. Visa meddelandet- Mata in ett tal på
            skärmen. c. Om det är under 10 får användaren ett meddelande som
            säger-Värdet är för lågt . Visa meddelandet- Mata in ett tal på
            skärmen. d. När användaren matar in 10 avbryts loopen och användaren får
            meddelandet – Du matade in rätt tal. e. Visa sedan alla tal som matats in innan användaren angav rätt tal. Skriv ut dessa i en lista
            f. Programmet avbryts.
             */

            //Func<int, int> func1 = x => x + 1;
            //Console.WriteLine("FUNC1: {0}", func1.Invoke(200));

            // {
            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Func<int, bool> oddCheck = x => x % 2 != 0; //If not even

            // var oddNumbers = numbers.Where(oddCheck);

            // Console.WriteLine();
            //oddNumbers.For(x => Console.WriteLine(x));

            /*Övningsuppgifter-Stränghantering
            1.Be användaren mata in 3 strängar. Addera ihop strängarna och skriv ut alla tre strängarna på
            skärmen. 
            */
            //string[] ordArray = new string[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Skriv en ord :");
            //    ordArray[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < ordArray.Length; i++)
            //{
            //    Console.Write(ordArray[i] +" ");
            //}
            /*
            2.Du har en strängvariabel som innehåller följande text, ”Hello, world” 
            a. Ta med hjälp av kod ut första förekomsten av bokstaven w
            b. Skriv ut vilken position bostaven w har i strängen (H har position 0). Ta fram positionen genom kod. 
            */

            //string str = "Hello, World";
            //int pos = str.LastIndexOf("W");
            //Console.WriteLine(str.LastIndexOf("W"));
            //Console.WriteLine($"W is att the number {pos} index.");

            /*
            3.Du har en strängvariabel som ser ut så här string b ="I am a C# hacker." 
            a. Skriv ut vilken position sista a har
            b. Skriv ut i vilken position ”C” har i strängen ovan. Skriv samtidigt
            ut längden på hela strängen ovan
            c. Skriv ut varje ord för sig under varandra i en skärmutskrift
            d. Plocka ut delsträngen ' hacker' ur b ovan via kod och skriv på
            skärmen
            e. Gör om strängen b så att den ser ut så här:" i Am A C# hAcKeR" 
            */
            //string str = "I am a C# hacker.";
            //str = str.Replace(".", "");
            //int lastPosA = str.LastIndexOf("a");
            //int lastPosC = str.LastIndexOf("C");
            //int strLength = str.Length;
            //string[] inToWords = str.Split(" ");

            //str = str.Replace("I", "i");
            //str = str.Replace("a", "A");
            //str = str.Replace("k", "K");
            //str = str.Replace("r", "R");

            //string hecker = inToWords[4];
            //Console.WriteLine(str);
            //Console.WriteLine("\n");
            //foreach (var item in inToWords)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine($"Last index of a is number : {lastPosA}");
            //Console.WriteLine($"Last index of a is number : {lastPosC}");
            //Console.WriteLine($"Word: {hecker}");

            /*


           4.Du har strängen string namn="kurt andersson";
           Skriv kod så att förnamn och efternamn i variabeln namn börjar
           med stora bokstäver. Resultatet skall bli så här "Kurt Andersson"
           */
            //string str = "kurt anderson";
            //string toUpper = str.Replace("k","K");
            //toUpper=toUpper.Replace("a", "A");
            //Console.WriteLine(toUpper);

            /*
            
            5.Du har en sträng med texten ”Detta är en sträng som du skall
            ändra”. Ersätt via kod alla blanktecken i strängen med tecknet * . Räkna
            sedan ut via kod hur många förekomster det finns av tecknet * i
            strängen. 

            */
            //string str = "Detta är en sträng som du skall ändra";
            //str = str.Replace(" ", "*");
            //int starCounter = 0;
            //char[] charts = str.ToCharArray();

            //foreach (char item in charts)
            //{
            //    switch (item)
            //    {
            //        case '*':
            //            starCounter++;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine(str);
            //Console.WriteLine(starCounter +" number of * in frase" ); 


            /*
            
            6.Du har en kommaseparerad sträng som ser ut så
            här ”ett,två,tre,fyra,fem,sex,sju”. 
            Skapa en array där varje värde i strängen hamnar i en egen position
            i arrayen dvs ett hamnar i första positionen och två i andra
            positionen och tre i den tredje osv. 
            */
            //string str = "ett, två, tre, fyra, fem, sex, sju";
            //str.Replace(" ", "");
            //string[] test = str.Split(',');

            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);
            //}
            /*

            
            7.Be användaren mata in en mailadress. Programmet skall
            kontrollera att inmatningen är rätt dvs att det finns ett @ tecken
            och att det finns en (.) med 2 eller 3 tecken efter. Meddela
            användaren om det är rätt eller felaktig adress
            */
            //string emailAdress = "";
            //Console.WriteLine("Vad är din email adress");
            //emailAdress = Console.ReadLine();

            //string emailAdress = "berg_gustav@hotmail.c";

            //emailAdress = emailAdress.Trim();

            //  bool att = emailAdress.Contains("@");
            //bool dot = emailAdress.Contains(".");
            //int indexOfDot = emailAdress.IndexOf(".");
            //int lengthOfEmail = emailAdress.Length;
            //int endToDotCount = (lengthOfEmail - 1) - indexOfDot;

            //if (endToDotCount > 3 || endToDotCount < 2)
            //{
            //    Console.WriteLine("Invalid email");
            //}
            //else if (att && dot)
            //{
            //    Console.WriteLine("Valid email");
            //}


            /*

            Lite svårare uppgifter:
            
            
            8.Sortera strängen "231596874" till strängen "123456789" med en egen
            sorteringsfunktion. 
            */
            //string randomized = "231596874";
            //int[] radomizedInt = new int[9];

            //char[] stillRandom = randomized.ToCharArray();
            //for (int i = 0; i < stillRandom.Length; i++)
            //{
            //    radomizedInt[i] = Convert.ToInt32(stillRandom[i] - 48);
            //}

            //int temp;
            ////foreach (var item in stillRandom)
            ////{
            ////    Console.Write(item);
            ////}

            //for (int i = 0; i < radomizedInt.Length - 1; i++)
            //{
            //    for (int j = 0; j < radomizedInt.Length - 1; j++)
            //    {
            //        if (radomizedInt[j] > radomizedInt[j + 1])
            //        {
            //            temp = radomizedInt[j + 1];
            //            radomizedInt[j + 1] = radomizedInt[j];
            //            radomizedInt[j] = temp;
            //        }

            //    }

            //}



            ////}
            //Console.WriteLine("\n");
            //foreach (var item in radomizedInt)
            //{
            //    Console.Write(item);
            //}





            /*


            9.Gör ett program där användaren får mata in en mening t ex ”Detta
            är min text som jag matar in”. Programmet skall räkna ut hur många
            ord meningen består av och meddela användaren om detta.

            */
            //string sentance = "Detta är min text som jag matar in";
            //char[] sentanceArray = sentance.ToCharArray();
            //int counter = 0;

            //foreach (char A in sentanceArray)
            //{
            //    switch (A)
            //    {
            //        case ' ':
            //            counter++;
            //            break;
            //        default:
            //            break;
            //    }

            //}
            //Console.WriteLine($"Meningen inehåller : {counter+1} ord.");


            /*


            10.Be användare mata in ett ord eller en mening. Programmet skall
            kontrollera om det ordet är en palindrom dvs om ordet blir likadant
            om man läser framifrån och bakifrån. Exempel på palindrom är
            namn som ”anna” eller ”otto” eller en mening som ”ni talar bra latin”. 
            Meddela användaren om det är en palindrom eller ej.

            */
            //string input = "naturrutan";
            //int inputLength = input.Length;
            //string inputReverse ="";
            //input = input.ToLower();            

            //char[] verse = input.ToCharArray();            

            //for (int i = verse.Length - 1; i > -1; i--)
            //{
            //    inputReverse += verse[i];
            //}
            //Console.WriteLine(inputReverse);
            //Console.WriteLine(input);
            //bool isReveseble = inputReverse.Equals(input);
            //Console.WriteLine($"String is palidrom = {isReveseble}");

            /*

             11.Be användaren mata in ett fullständigt personnummer. Koden
             skall kontrollera om det är ett giltigt personnummer. Meddela
             användaren om det är ett giltigt eller ogiltigt personnummer. Ett
             personnummer räknas ut enligt den så kallade ”10-modulmetoden” 
            ( sök på det så hittar ni vilka regler som gäller för uträkningen)*/

            //Console.WriteLine("Skriv in ett personnummer. 10 siffror.");
            //long sSNumber;

            //string nummer = "8306061233";//Console.ReadLine(); //personnummer as string

            //char[] numArray = nummer.ToCharArray(); //personnummer as CharArray

            //int[] numIntArray = new int[10];

            //int temp1 =0;

            //int temp2 = 0;

            //do
            //{             

            //    for (int i = 0; i < numArray.Length; i++)//Char array to int array.
            //    {
            //        numIntArray[i] = (numArray[i] - '0');
            //    }
            //    try
            //    {
            //        sSNumber = Convert.ToInt64(nummer);
            //        break;
            //    }
            //    catch (Exception F)
            //    {
            //        Console.WriteLine($"Fel {F}");

            //    }
            //} while (true);

            //for (int i = 0; i < numIntArray.Length; i++)
            //{
            //    if (i%2 == 1)// if odd do this if even do that
            //    {
            //        temp1 = numIntArray[i] * 2;
            //        if (temp1 < 9)//if double digit split them up and add
            //        {
            //            string dubleDigits = temp1.ToString();

            //            char[] singleDigits = dubleDigits.ToCharArray();

            //            for (int j = 0; j < singleDigits.Length; j++)
            //            {
            //                temp2 = temp2 + (singleDigits[j]-48);
            //            }
            //        }

            //    }
            //    else
            //    {
            //        temp2 = temp2 + (numIntArray[i] * 1);
            //    }

            //}
            //Console.WriteLine(temp2);
            //Console.WriteLine(temp2/10);

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
