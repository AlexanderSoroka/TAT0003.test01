using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      List<int> collection = new List<int>{ 1, 2, 3, 1, 2, 3, 1, 2, 3 };
      RepeatsChecker repeatsChecker = new RepeatsChecker(collection);
      Console.Write(repeatsChecker.GetRepetitiveElementsCount());
    }
   
  }
}
