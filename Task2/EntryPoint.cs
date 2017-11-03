using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
  // Count repeating elements from the collection.
  class EntryPoint
  {
    static void Main(string[] args)
    {
      var collection = new List<int>{ 1, 2, 1, 3 };
      RepeatingElementsRemover<int> remover = new RepeatingElementsRemover<int>();
      remover.RemoveRepeatingElements(collection);

      Console.WriteLine(AssemblyInfo.resultMessage);
      StringBuilder result = new StringBuilder();
      foreach (var element in collection)
      {
        result.Append(element.ToString() + ' ');
      }
      Console.WriteLine(result);
    }
  }
}
