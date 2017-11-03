using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task_2
{
  class Program
  {
    static void Main(string[] args)
    {
      ReapetedElements reapetedElements = new ReapetedElements();
      ArrayList list = new ArrayList() { 1, 2, 3 ,2,1,3,4,5,6,7,4,5};
      Console.WriteLine(reapetedElements.GetReapetedElements(list));
    
    }
  }
}
