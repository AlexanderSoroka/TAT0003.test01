using System;
using System.Collections.Generic;

namespace Task2
{
  /// <summary>
  /// Main method of this class
  /// calls method of class CollectionAnalyser
  /// that calculates the number of repetitive items in collections
  /// </summary>
  public class EntryPoint
  {
    private const string Item = "Item: ";
    private const string Repeats = "Repeats: ";

    /// <summary>
    /// Method displays the result
    /// of checking the input collection for duplicates
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      try
      {
        List<int> testedCollectionInts = new List<int>();

        Dictionary<int,int> duplicatedItemsDictionary = (new CollectionAnalyzer()).DuplicatedItemsDictionary(testedCollectionInts);

        foreach (var item in duplicatedItemsDictionary)
        {
          Console.WriteLine($"{Item}{item.Key} {Repeats}{item.Value}\n");
        }
        Console.ReadKey();
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
