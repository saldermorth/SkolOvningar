using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infected
{
    public class Person
    {
        public bool smittad;
        public int smittadNär;
        public bool immun;

        public Person(bool _smittad, int _smittadNär, bool _immun)
        {
            smittad = _smittad;
            smittadNär = _smittadNär;
            immun = _immun;
        }
    }
}
