using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class EntryPOint
    {
        static void Main(string[] args)
        {
            try
            {
                string pathFromConsole = Console.ReadLine();
                ValidatoinClass validPath = new ValidatoinClass(pathFromConsole);
                Console.WriteLine(validPath.isValidFilePath());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
