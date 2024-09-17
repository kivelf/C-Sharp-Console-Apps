using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05Opg03
{
    internal class SortByScoreDesc : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return y.Score.CompareTo(x.Score);
        }
    }
}
