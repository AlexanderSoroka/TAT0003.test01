using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_3
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Auto> listOfAuto = new List<Auto>();
      DataProvider provider = new DataProvider();
      Sorter sorter = new Sorter();
      provider.enterDataTo(listOfAuto);
      listOfAuto = sorter.SortByMark(sorter.SortByType(sorter.SortByPrice(listOfAuto)));
      for (int i = 0; i < listOfAuto.Count; i++)
      {
      Console.WriteLine(listOfAuto[i]);
      }
    }
  }
}
