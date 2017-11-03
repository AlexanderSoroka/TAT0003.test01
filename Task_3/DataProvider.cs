using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_3
{
  class DataProvider
  {
    public void enterDataTo(List<Auto> listOfAuto) {
    AutoBuilder builder = new AutoBuilder();
    do {
      listOfAuto.Add(builder.build());
    } while (requestForInput());
  }

  private bool requestForInput() {
    Console.WriteLine("If you want to enter information for one more product press YES,otherwise press ENTER.");
    switch (Console.ReadLine()) {
      case "YES":
        return true;
      default:
        return false;
    }
  }
}
