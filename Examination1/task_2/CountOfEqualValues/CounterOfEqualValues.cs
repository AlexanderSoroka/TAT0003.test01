using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountOfEqualValues
{
  /// <summary>
  /// This class counts the number of equal elements on collection.
  /// </summary>
  class CounterOfEqualValues
  {
    private ArrayList collcetionOfValues;
    public ArrayList CollcetionOfValues
    { get; set; }

    /// <summary>
    /// This method reads elements of collection from file
    /// </summary>
    /// <param name="currentLine">current line of reading file</param>
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

    /// <summary>
    /// This method counts the equal elements of collection
    /// </summary>
    /// <returns>quantity of equal elements</returns>
    public int CounterOfValues()
    {
      StringBuilder resultLine = new StringBuilder();
      ArrayList result = new ArrayList();
      for(int i = 0; i < CollcetionOfValues.Count; i++)
      {
        for(int j = i + 1; j < CollcetionOfValues.Count; j++)
        {
          if (CollcetionOfValues[i].Equals(CollcetionOfValues[j]))
          {
            if (!(result.Contains(CollcetionOfValues[i])))
            {
              result.Add(CollcetionOfValues[i]);
            }
 
     
          }
        }
      }
      foreach(object value in CollcetionOfValues)
      {
        resultLine.Append(value);
      }
      return result.Count;
    }
  }
}
