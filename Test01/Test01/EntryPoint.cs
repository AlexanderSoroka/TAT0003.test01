using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayValidation
{
  class EntryPoint
  {
    static void Main (string[] args)
    {
      try
      {
        Validator validator = new Validator();
        foreach (var line in args)
        {
          validator.ChecksIfFileWayContainsForbiddenSymbols(line);
          if (validator.Valid)
          {
            StringBuilder output = new StringBuilder("The line\n" + line + "\nis valid");
            Console.WriteLine(output);
          }
          else
          {
            StringBuilder output = new StringBuilder("The line\n" + line + "\nisn't valid");
            Console.WriteLine(output);
          }
        }
      }
      finally
      {
        Console.WriteLine("Press any key for exit");
        Console.ReadKey();
      }
    }
  }
}
