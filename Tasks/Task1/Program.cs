using System;

namespace Task1
{
  /// <summary>
  /// This class contain method
  /// that checks the path to the file
  /// passed as a command-line argument
  /// </summary>
  public class EntryPoint
  {
    private const string InvalidFileName = "Invalid file name";

    /// <summary>
    /// Method contain two if blocks
    /// First checks that command line is not empty
    /// Second checks that the path is valid
    /// </summary>
    /// <param name="args">The path to file</param>
    static void Main(string[] args)
    {
      try
      {
        if (args.Length == 0)
        {
          throw new ArgumentNullException();
        }
        if (args[0].IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) != -1)
        {
          throw new Exception(InvalidFileName);
        }
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
