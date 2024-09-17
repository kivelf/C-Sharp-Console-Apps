using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05Opg03
{
    internal static class Exts
    {
        public static void SetAccepted(this List<Person> ppl, Predicate<Person> condition) 
        { 
            ppl.FindAll(condition).ForEach(p => p.Accepted = true);
        }
    }
}
