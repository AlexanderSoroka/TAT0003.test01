using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class ValidatoinClass
    {
        private string pathFromConsole;
        const string SPECIALSIGNS = "*|\"<>/?%";
        const string FIRSTSYMBOL = "CDEF";
        public ValidatoinClass(string pathFromConsole)
        {
            this.pathFromConsole = pathFromConsole;
        }
        //this ValidatoinClass:isValidFilePat method checks if the path is valid
        public bool isValidFilePath()
        {
            try
            {
                if (!FIRSTSYMBOL.Contains(getFirstSymbol(pathFromConsole)))
                    return false;

                for (int i = 0; i <= pathFromConsole.Length - 1; i++)
                {
                    if (SPECIALSIGNS.Contains(pathFromConsole[i]))
                    {
                        return false;
                    }
                }                
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
                
        }
        //this ValidatoinClass:getFirstSymbol method returns first symbol of entry string
        private char getFirstSymbol(string path)
        {
            return path[0];
        }

    }
}
