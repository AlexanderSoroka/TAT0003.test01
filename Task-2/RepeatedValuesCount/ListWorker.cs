using System;
using System.Collections;
using System.IO;
using System.Text;

namespace RepeatedValuesCount
{
  class ListWorker
  {
    public ArrayList ValuesList { get; set; }

    /// <summary>
    /// This method allocates memory for the collection, initializes this collection by values from file. 
    /// </summary>
    /// <param name="filePath"> takes the path of our file </param>
    public void InitializeList(string filePath)
    {
      ValuesList = new ArrayList();
      using (StreamReader streamReader = new StreamReader(filePath, Encoding.Default))
      {
        while (!streamReader.EndOfStream)
        {
          ValuesList.Add(streamReader.ReadLine());
        }
      }
    }

    /// <summary>
    /// This method prints collection on console.
    /// </summary>
    public void OutputListOnConsole()
    {
      StringBuilder valuesListString = new StringBuilder();
      foreach (object element in ValuesList)
      {
        valuesListString.Append(element).Append(" ");
      }
      Console.WriteLine(valuesListString.ToString());
    }

    /// <summary>
    /// This method count repeated values in collection. 
    /// </summary>
    /// <returns> count of repeated values in collection </returns>
    public int CountRepeatedElements()
    {
      int count = 0;
      ArrayList list = new ArrayList();
      list.AddRange(ValuesList);
      for (int i = 0; i < ValuesList.Count; i++)
      {
        for (int j = i + 1; j < ValuesList.Count; j++)
        {
          if (ValuesList[i].Equals(ValuesList[j]))
          {
            count++;
            list.Remove(ValuesList[i]);
          }
        }
      }
      return count;
    }
  }
}