using System;

namespace MerryMethodsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shout = false;
            MethodBench bench = new MethodBench();
            int i = 3;
            do
            {
                bench.FirstMethod();
                i--;
            } while (i>0);
            
            string s = "C# Now and Forever!";
            bench.SecondMethod("C# Now and Forever!");
            bench.SecondMethod(s);
            Console.WriteLine("String to (1)upper case or (2)lower case? ");
            int upperOrLower = Convert.ToInt32(Console.ReadLine());
            bool upper = false;
            if (upperOrLower == 1)
            {
                upper = true;
            }
            else if (upperOrLower == 2)
            {
                upper = false;
            }
            bench.ThirdMethod(s, upper);
            shout = bench.FourthMethod();
            bench.ThirdMethod(s, shout);
        }
    }
}
