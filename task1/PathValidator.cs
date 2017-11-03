using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
  class PathValidator
  {
    public bool IsDiskNameCorrect {get; set; }
    public bool IsPathValid { get; set; }
    string[] pathParts;
    public PathValidator(string path)
    {
      pathParts = path.Split('\\');
      IsDiskNameCorrect = DiskNameChecker(path);
      IsPathValid = PathValidateChecker(pathParts);
    }
    // This method checks if the name of disk is valid.
    private bool DiskNameChecker(string path)
    {
      return (pathParts[0][pathParts[0].Length - 1] == ':');
    }
    // This method checks if each part of path
    private bool PathValidateChecker(string[] pathPieces)
    {
      string notValidSymbols = "\\/:*?\"<>|";
      for (int i = 1; i < pathPieces.Length; i++)
      {
        for (int j = 0; j < pathPieces[i].Length; j++)
        {
          for (int k=0;k<notValidSymbols.Length;k++)
          {
             if(pathPieces[i][j]==notValidSymbols[k])
               return false;
          }
        }
      }
      return true;
    }
  }
}
