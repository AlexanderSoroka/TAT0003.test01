using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task_2
{
  class ReapetedElements
  {
    public int GetReapetedElements(ArrayList list)
    {
      int count = 0;
      ArrayList result = new ArrayList();
      if (list.Count == 1)
      {
        return 1;
      }
      else if (list.Count == 0)
      {
        return 0;
      }
      list.Sort();
      for (int i = 0; i < list.Count - 1; i++)
      {
        if (list[i].Equals(list[i + 1]) && !result.Contains(list[i]))
        {
          count++;
        }
      }
      if (list[list.Count - 1].Equals(list[list.Count - 2]) && !result.Contains(list[list.Count - 1]))
      {
        count++;
      }
      return count;
    }
  }
}
