using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PathValidation
{
  /// <summary>
  /// This class realizes to validation of the path. 
  /// </summary>
  class CheckingOfPath
  {
    /// <summary>
    /// This method checks whether the path is correct.
    /// </summary>
    /// <param name="path">Path, which need check.</param>
    /// <returns>Returns true, if path contains invalid symbols and false if doesn't contain.</returns>
    public bool СheckOfPath(string path)
    {
      for (int i = 0; i < Path.GetInvalidPathChars().Length; i++)
      {
        if (path.Contains(Path.GetInvalidPathChars()[i]))
        {
          return true;
        }
      }
      return false;
    }
  }
}
