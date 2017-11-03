using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingObjects
{
  class Searcher
  {
    string lineForSearch;
    List<string> ListToSearchIn;
    int quantityOfRepeatingObjects;
    public int QuantityOfRepeatingObjects
    {
      get => quantityOfRepeatingObjects;
    }
    public Searcher(string line, List<string> list)
    {
      lineForSearch = line;
      ListToSearchIn = list;
      quantityOfRepeatingObjects = 0;
    }
    public void CountReapitings ()
    {
      foreach (var line in ListToSearchIn)
      {
        if (line.Equals(lineForSearch))
        {
          quantityOfRepeatingObjects += 1;
        }
      }
    }
  }
}
