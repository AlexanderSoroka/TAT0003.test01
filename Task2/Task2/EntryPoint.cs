using System;
using System.Collections.Generic;

namespace Task2
{
  //The entry point of the program.
  class EntryPoint
  {
    static void Main(string[] args)
    {
      List<int> listNumbers = new List<int>() { 2, 2, 3, 45, 2, 3, 81 };
      List<int> listResult = new List<int>();
      DuplicateItemsSearcher duplicateItemsSearcher = new DuplicateItemsSearcher();
      List<int> listDuplicateItems = duplicateItemsSearcher.SearcherDuplicateItems(listNumbers, listResult);
      duplicateItemsSearcher.OutputDuplicateItems(listDuplicateItems);
      duplicateItemsSearcher.OutputNumOfRepetitions(listDuplicateItems);
      Console.ReadKey();
    }
  }
}
