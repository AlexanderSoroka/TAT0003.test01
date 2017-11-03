using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfEqualValues
{
  /// <summary>
  /// The entry point of programm
  /// </summary>
  class Program
  {
    const string StringValues = @"e:\StringValues.txt";
    const string NumberValues = @"e:\NumberValues.txt";
    static void Main(string[] args)
    {
      try
      {
        CounterOfEqualValues counterOfEqualValues = new CounterOfEqualValues();
        counterOfEqualValues.ReadFile(StringValues);
        Console.WriteLine(counterOfEqualValues.CounterOfValues());
        counterOfEqualValues.ReadFile(NumberValues);
        Console.WriteLine(counterOfEqualValues.CounterOfValues());
        Console.ReadKey();
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
