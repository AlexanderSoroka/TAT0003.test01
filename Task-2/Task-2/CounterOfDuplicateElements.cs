using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
  class CounterOfDuplicateElements
  {
    private Sorting sorter = new Sorting();
    private BinarySearch searcher = new BinarySearch();

    private List<int> ReturnHashesSubstrings(List<string> arrayOfStrings)
    {
      List<int> result = new List<int>();
      for (int i = 0; i < arrayOfStrings.Count; i++)
      {
        result.Add(arrayOfStrings[i].GetHashCode());
      }
      return result;
    }

    private List<string> GetArrayOfDuplicateElements(List<string> arrayOfStrings)
    {
      List<string> duplicateElements = new List<string>();
      List<int> hashesSubstrings = ReturnHashesSubstrings(arrayOfStrings);

      for (int i = 0; i < hashesSubstrings.Count; i++)
      {
        if (searcher.SearchesBinary(sorter.SortArray(hashesSubstrings), hashesSubstrings[i]) || !duplicateElements.Contains(arrayOfStrings[i]))
        {
          duplicateElements.Add(arrayOfStrings[i]);
        }
      }
      return duplicateElements;
    }

    public int returnOfQuantityOfDuplicateElemenst(List<string> arrayOfStrings)
    {
      return GetArrayOfDuplicateElements(arrayOfStrings).Count;
    }

  }
}
