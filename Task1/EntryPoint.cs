using System;

namespace Task1
{
  // Validate file path to the object in OS Windows.
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string filePath = args[0];
      FilePathValidator validator = new FilePathValidator(); 

      Console.WriteLine(AssemblyInfo.resultMessage);
      Console.WriteLine(validator.Validate(filePath));
    }
  }
}
