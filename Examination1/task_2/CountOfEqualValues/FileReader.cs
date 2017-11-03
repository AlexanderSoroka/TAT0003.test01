using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountOfEqualValues
{
  class FileReader
  {
    public void ReadFile(string currentLine)
    {
      CounterOfEqualValues counterOfEqualValues = new CounterOfEqualValues();
      counterOfEqualValues.CollcetionOfValues = new ArrayList();
      using (StreamReader readLine = new StreamReader(currentLine))
      {
        while ((!readLine.EndOfStream))
        {
          counterOfEqualValues.CollcetionOfValues.Add(readLine.ReadLine());
        }         
      }    
    }
  }
}
