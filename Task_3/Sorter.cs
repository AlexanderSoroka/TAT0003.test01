using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_3
{
  class Sorter
  {
   
    public List<Auto> SortByPrice(List<Auto> list)
    {
      Auto value = null;
      bool count = true;
      while (count)
      {
        count = false;
        for (int i = 0; i < list.Count - 1; i++)
        {
          if (list[i].GetPrice() > list[i + 1].GetPrice())
          {
            value = list[i];
            list[i] = list[i + 1];
            list[i + 1] = value;
            count = true;
          }
        }
      }
      return list;
    }

    public List<Auto> SortByMark(List<Auto> list)
    {
      Auto value = null;
      bool count = true;
      while (count)
      {
        count = false;
        for (int i = 0; i < list.Count - 1; i++)
        {
          if (list[i].GetMark().CompareTo(list[i + 1].GetMark()) > 0)
          {
            value = list[i];
            list[i] = list[i + 1];
            list[i + 1] = value;
            count = true;
          }
        }
      }
      return list;
    }

    public List<Auto> SortByType(List<Auto> list)
    {
      Auto value = null;
      bool count = true;
      while (count)
      {
        count = false;
        for (int i = 0; i < list.Count - 1; i++)
        {
          if (list[i].GetType().CompareTo(list[i + 1].GetType()) > 0)
          {
            value = list[i];
            list[i] = list[i + 1];
            list[i + 1] = value;
            count = true;
          }
        }
      }
      return list;
    }
  }

