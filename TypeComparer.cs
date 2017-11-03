using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class TypeComparer: IComparer<Automobile>
    {
        public int Compare(Automobile first, Automobile second)
        {
            return string.CompareOrdinal(first.information.Type, second.information.Type);
        }
    }
}
