using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountOfEqualValues
{
  class CounterOfEqualValues
  {
    private ArrayList collcetionOfValues;
    public ArrayList CollcetionOfValues
    { get; set; }

    public void ReadFile(string currentLine)
    {
      CollcetionOfValues = new ArrayList();
      using (StreamReader readLine = new StreamReader(currentLine))
      {
        while ((!readLine.EndOfStream))
        {
          CollcetionOfValues.Add(readLine.ReadLine());
        }
      }
    }

    public int CounterOfValues()
    {
      StringBuilder resultLine = new StringBuilder();
      int counter = 0;
      for(int i = 0; i < CollcetionOfValues.Count; i++)
      {
        for(int j = i + 1; j < CollcetionOfValues.Count; j++)
        {
          if (CollcetionOfValues[i].Equals(CollcetionOfValues[j]) || CollcetionOfValues[i] == CollcetionOfValues[j])
          {
            CollcetionOfValues.Remove(CollcetionOfValues[i]);
            counter++;
          }
        }
      }
      foreach(object value in CollcetionOfValues)
      {
        resultLine.Append(value);
      }
      return counter;
    }
  }
}
