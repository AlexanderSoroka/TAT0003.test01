using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class MarkComparer : IComparer<Automobile>
    {
        public int Compare(Automobile first, Automobile second)
        {
            return string.CompareOrdinal(first.information.Mark, second.information.Mark);
        }
    }
}
