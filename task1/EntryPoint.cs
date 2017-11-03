using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string path = args[0];
      PathValidator validator = new PathValidator(args[0]);
      Console.Write(validator.IsPathValid);
      Console.ReadKey();
    }
  }
}
