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
    string[] pathPieces;
    public PathValidator(string path)
    {
      pathPieces = path.Split('\\');
      IsDiskNameCorrect = DiskNameChecker(path);
      IsPathValid = PathValidateChecker(pathPieces);
    }

    private bool DiskNameChecker(string path)
    {
      return (pathPieces[0][pathPieces[0].Length - 1] == ':');
    }
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
