using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerryMethodsProject
{
    public class MethodBench
    {
        public void FirstMethod()
        {
            Console.WriteLine("Merry Method");
        }
        public void SecondMethod(string s)
        {
           
            Console.WriteLine(s);
        }
        public void ThirdMethod(string s , bool b)
        {
                        
            if (b)
            {
                s = s.ToUpper();
            }
            else
            {
                s = s.ToLower();
            }
            SecondMethod(s);
        }
        public bool FourthMethod()
        {
            bool shout = false;
            Console.WriteLine("Ska datorn (S)krika eller (V)iska?");


            if (Console.ReadKey().Key != ConsoleKey.S)
            {
                shout = false;
            }
            else if (Console.ReadKey().Key != ConsoleKey.V)
            {
                shout = true;
            }
            return shout;

        }
    }
}
