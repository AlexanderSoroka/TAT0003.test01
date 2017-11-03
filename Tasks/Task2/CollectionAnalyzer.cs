using System.Collections.Generic;
using System.Linq;

namespace Task2
{
  /// <summary>
  /// Class contains method
  /// that collects in dictionary elements from input collection
  /// and help method
  /// that remove from dictionary non duplicated elements
  /// </summary>
  public class CollectionAnalyzer
  {
    public Dictionary<T, int> DuplicatedItemsDictionary<T>(IEnumerable<T> collection)
    {
      Dictionary<T,int> resultDictionary = new Dictionary<T, int>();

      foreach (var item in collection)
      {
        int count = 0;
        resultDictionary.TryGetValue(item, out count);
        resultDictionary[item] = count + 1;
      }

      return RemoveNonDuplicatedItemsFromDictionary(resultDictionary);
    }

    private Dictionary<T, int> RemoveNonDuplicatedItemsFromDictionary<T>(Dictionary<T, int> dictionary)
    {
      Dictionary<T, int> resultDictionary = dictionary;
      foreach (var item in dictionary.Where(item => item.Value == 1).ToList())
      {
        resultDictionary.Remove(item.Key);
      }
      return resultDictionary;
    }
  }
}
