using System.Collections.Generic;

namespace Number2
{
  class CheckForNonUniqueElement
  {
   private List<int> NumbersForCheckin { get; set; }

   public CheckForNonUniqueElement(List<int> numbersForChecking)
    {
      NumbersForCheckin = numbersForChecking;
    }

    //Check: is every element in collection is unique or not unique and add it(not unique) to the result collection.
    public List<int> CheckTheNonUniqueElementOfArray(List<int> numbers)
    {
      List<int> resultArray = new List<int>();
      for (int i = 0; i < numbers.Count; i++)
      {
        int unique = 0;
        for (int j = 0; j < numbers.Count; j++)
        {
          if (numbers[i] == numbers[j])
          {
            unique++;
          }
        }
        if (unique > 1)
        {
          if (!resultArray.Contains(numbers[i]))
          {
            resultArray.Add(numbers[i]);
          }
        }
      }
      return resultArray;
    }

    //For counting repetitive elements.
    public int CountNonUniqueElement(List<int> arrayOfNonUniqueElement)
    {
      return arrayOfNonUniqueElement.Count;
    }
  }
}
