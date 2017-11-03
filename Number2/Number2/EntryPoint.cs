using System.Collections.Generic;
using static System.Console;

namespace Number2
{
  //The entry point of the programm.
  class EntryPoint
  {
    //For colling the methods for checking repetitive elements.
    static void Main()
    {
      List<int> numbersForChecking = new List<int>() { 1, 1, 2, 3, 45, 2 };
      CheckForNonUniqueElement checkNonUniqueElement = new CheckForNonUniqueElement(numbersForChecking);
      List<int> arrayOfNonUniqueElement = checkNonUniqueElement.CheckTheNonUniqueElementOfArray(numbersForChecking);
      Write(checkNonUniqueElement.CountNonUniqueElement(arrayOfNonUniqueElement));

      ReadKey();
    }
  }
}
