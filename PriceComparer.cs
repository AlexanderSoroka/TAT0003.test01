using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class PriceComparer: IComparer<Automobile>
    {
        public int Compare(Automobile first, Automobile second)
        {
            int result = -1;
            if ((first.information.Price - second.information.Price) < double.Epsilon)
            {
                result = 0;
            }
            else if (first.information.Price - second.information.Price > double.Epsilon)
            {
                result = 1;
            }
            return result;
        } 

    }
}
