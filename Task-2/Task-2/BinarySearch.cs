using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
  class BinarySearch
  {
    public bool SearchesBinary(List<int> sortedSet, int value)
    {

      if ((sortedSet.Count == 0) || (value < sortedSet[0]) || (value > sortedSet[sortedSet.Count - 1]))
      {
        return false;
      }

      int first = 0;
      int last = sortedSet.Count;

      while (first < last)
      {
        int middleOfSortedSet = first + (last - first) / 2;

        if (value <= sortedSet[middleOfSortedSet])
        {
          last = middleOfSortedSet;
        }
        else
        {
          first = middleOfSortedSet + 1;
        }
      }
      return sortedSet[last] == value;
    }
  }
}
