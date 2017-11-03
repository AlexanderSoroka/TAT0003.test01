using System;
using System.IO;
using System.Text;

namespace Task1
{
  // Provides the mechanism to validate filepath in os Windows.
  public class FilePathValidator
  {
    // Validate filepath.
    public string Validate(string filePath)
    {
      StringBuilder validatedFilePath = new StringBuilder(filePath);

      // Remove unsupported symbols.
      foreach (char symbol in Path.GetInvalidPathChars())
      {
        validatedFilePath = validatedFilePath.Replace(symbol.ToString(), string.Empty);
      }

      // Remove spaces.
      validatedFilePath = validatedFilePath.Replace(" ", string.Empty);

      return validatedFilePath.ToString();
    }
  }
}
