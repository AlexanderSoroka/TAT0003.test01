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
    int quantityOfReapitingObjects;
    public int QuantityOfReapitingObjects
    {
      get => quantityOfReapitingObjects;
    }
    public Searcher(string line, List<string> list)
    {
      lineForSearch = line;
      ListToSearchIn = list;
      quantityOfReapitingObjects = 0;
    }
    public void CountReapitings ()
    {
      foreach (var line in ListToSearchIn)
      {
        if (line.Equals(lineForSearch))
        {
          quantityOfReapitingObjects += 1;
        }
      }
    }
  }
}
