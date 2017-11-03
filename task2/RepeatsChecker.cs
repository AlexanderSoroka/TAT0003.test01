using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
  class RepeatsChecker
  {
    // This class is used for detect the repeats in
    // List<int> collection.
    public List<int> Collection { get; set; }
    public List<int> RepetitiveElements { get; set; }
    public RepeatsChecker(List<int> collection)
    {
      this.Collection = collection;
      RepetitiveElements = new List<int>();
      FindRepetitiveElements();
    }
    // This method detects the repeats and write them down
    // into RepetetiveElements List.
    private void FindRepetitiveElements()
    {
      for (int i = 0; i < Collection.Count; i++)
      {
        bool flag = false;
        for (int j = i + 1; j < Collection.Count; j++)
        {
          if (Collection[i] == Collection[j])
          {
            flag = true;
            break;
          }
        }
        if (flag && !RepetitiveElements.Contains(Collection[i]))
        {
          RepetitiveElements.Add(Collection[i]);
        }
      }
    }
    // This method is used for getting the count of 
    // repetitive elements.
    public int GetRepetitiveElementsCount()
    {
      return RepetitiveElements.Count;
    }
  }
}
