using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool possiblePath = true;
            try
            {
                string path = Console.ReadLine();
                Checker MyChecker = new Checker();
                possiblePath = MyChecker.Check(path);
             
            }
            catch
            {
                Console.WriteLine("Wrong format!");
            }
            Console.WriteLine("Path is " + possiblePath);
            Console.ReadLine();
        }
    }
}
