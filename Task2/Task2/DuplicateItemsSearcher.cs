using System;
using System.Collections.Generic;

namespace Task2
{
  //This class is used to find and consume duplicate items and number of repetitions on the console.
  class DuplicateItemsSearcher
  {
    //This method is used to find duplicate items.
    public List<int> SearcherDuplicateItems(List<int> listNumbers, List<int> listResult)
    {
      for (int i = 0; i < listNumbers.Count; i++)
      {
        int copy = 0;
        for (int j = 1; j < listNumbers.Count; j++)
        {
          if (listNumbers[i] == listNumbers[j])
          {
            copy++;
          }
        }
        if (copy >= 2)
        {
          listResult.Add(listNumbers[i]);
        }
      }
      return listResult;
    }

    //This method is used to output duplicate items.
    public void OutputDuplicateItems(List<int> listResult)
    {
      foreach (int item in listResult)
      {
        Console.Write(item);
      }
    }

    //This method is used to output number of repetitions.
    public void OutputNumOfRepetitions(List<int> listResult)
    {
      int number = 0;
      for (int i = 0; i < listResult.Count; i++)
      {
        if (listResult.Contains(i))
        {
          number++;
        }
      }
      Console.WriteLine("\nNumber of repetitions: " + number);      
    }
  }
}
