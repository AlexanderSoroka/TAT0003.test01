using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingObjects
{
  class EntryPoint
  {
    static void Main (string[] args)
    {
      const int MaxSizeOfList = 100;
      List<string> listOfStrings = new List<string>();
      bool stop = false;
      do
      {
        string inputLine = Console.ReadLine();
        if (inputLine.Equals(String.Empty))
        {
          stop = true;
        }
        else
        {
          listOfStrings.Add(inputLine);
        }
        if (listOfStrings.Capacity == MaxSizeOfList)
        {
          stop = true;
        }
      }
      while (!stop);
      List<string> counted = new List<string>();
      foreach (var str in listOfStrings)
      {
        if (!counted.Contains(str))
        {
          Searcher searcher = new Searcher(str, listOfStrings);
          searcher.CountReapitings();
          int quantityOfRepeatings = searcher.QuantityOfRepeatingObjects;
          StringBuilder output = new StringBuilder("Line " + str + " repeats for " + quantityOfRepeatings 
                                                    + " times");
          Console.WriteLine(output);
          counted.Add(str);
        }
      }
      Console.WriteLine("Press any key for exit");
      Console.ReadLine();
    }
  }
}
