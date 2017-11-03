using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
  class Sorting
  {
    public List<int> SortArray(List<int> array)
    {
      if (array.Count == 1)
      {
        return array;
      }

      List<int> left = new List<int>();
      List<int> right = new List<int>();

      for (int i = 0; i < array.Count / 2; i++)
      {
        left.Add(array[i]);
      }

      for (int i = array.Count / 2; i < array.Count; i++)
      {
        right.Add(array[i]);
      }
      return Merge(SortArray(left), SortArray(right));
    }

    private List<int> Merge(List<int> left, List<int> right)
    {
      int leftCount = 0;
      int rightCount = 0;
      List<int> result = new List<int>();
      while (left.Count > leftCount && right.Count > rightCount)
      {
        if (left[leftCount].CompareTo(right[rightCount]) < 0)
        {
          result.Add(left[leftCount]);
          leftCount++;
        }
        else
        {
          result.Add(right[rightCount]);
          rightCount++;
        }
      }
      if (left.Count > leftCount)
      {
        for (int i = leftCount; i < left.Count; i++)
        {
          result.Add(left[i]);
        }
      }
      else
      {
        for (int i = rightCount; i < right.Count; i++)
        {
          result.Add(right[i]);
        }
      }
      return result;
    }
  }
}

