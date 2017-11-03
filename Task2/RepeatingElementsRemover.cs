using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
  public class RepeatingElementsRemover<T>
  {
    public IEnumerable<T> RemoveRepeatingElements(IEnumerable<T> collection)
    {
      HashSet<T> newCollection = new HashSet<T>();

      foreach (var element in collection)
      {
        newCollection.Add(element);
      }


      return newcollection;
    }
  }
}
