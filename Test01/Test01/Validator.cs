using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayValidation
{
  class Validator
  {
    char[] foriddenSymbols = { '*', '|', '"', '<', '>', '?', '/' };
    bool valid;
    public bool Valid
    {
      get => valid;
    }    
    public void ChecksIfFileWayContainsForbiddenSymbols(string fileWay)
    {
      foreach(var symbol in foriddenSymbols)
      {
        if (fileWay.Contains(foriddenSymbols[symbol]))
        {
          valid = false;
          break;
        }
        valid = true;
      }
    }
  }
}
