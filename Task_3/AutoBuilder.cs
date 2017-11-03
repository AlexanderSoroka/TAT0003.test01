using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_3
{
    
  class AutoBuilder
  {
    private string mark;
    private string model;
    private string type;
    private double price;

    public Auto build() {
      try
      {
        dataInput();
        return new Auto(mark, model, type, price);
      }
      catch (ArgumentException exception)
      {
        Console.WriteLine("Wrong format.Try again.");
        return this.build();
      }
    }

    private void dataInput() 
    {
    Console.WriteLine("Enter mark of product : ");
    type = Console.ReadLine();
    Console.WriteLine("Enter model of product : ");
    model = Console.ReadLine();
    Console.WriteLine("Enter type of product : ");
    type = Console.ReadLine();
    Console.WriteLine("Enter price of product : ");
    price = (double)Console.Read();
    }
  }
}
