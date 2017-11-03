using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      CreatingOfRandomArrayOfRandomStrings creatingOfRandomArray = new CreatingOfRandomArrayOfRandomStrings();

      List<string> array = creatingOfRandomArray.CreateRandomArrayOfRandomStrings();

      CounterOfDuplicateElements counter = new CounterOfDuplicateElements();
      Console.WriteLine(counter.returnOfQuantityOfDuplicateElemenst(array));
    }
  }
}
