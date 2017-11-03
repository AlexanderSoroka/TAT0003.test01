using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (Directory.Exists(args[0]))
                {
                    Console.WriteLine("It is valid path");
                }
                else
                {
                    Console.WriteLine("It is non-valid path");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
