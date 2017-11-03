using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PathValidation
{
  class EntryPoint
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Enter path to file:");
      args = new string[1];
      args[0] = Console.ReadLine();

      CheckingOfPath inspectorOfPath = new CheckingOfPath();

      if (inspectorOfPath.СheckOfPath(args[0]))
      {
        Console.WriteLine("This path is not exist.");
      }
      else
      {
        Console.WriteLine("This path is exist.");
      }
    }
  }
}
