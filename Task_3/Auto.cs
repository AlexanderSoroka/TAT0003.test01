using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_3
{
  class Auto
  {
    private string mark;
    private string model;
    private string type;
    private double price;

    public Auto(string mark, string model, string type, double price)
    {
      if (verify(mark, model, type, price))
      {
        this.mark = mark;
        this.model = model;
        this.type = type;
        this.price = price;
      }
      else
      {
        throw new ArgumentException();
      }
    }

    private bool verify(string mark, string model, string type, double price)
    {
      return (isCorrect(mark) && isCorrect(type) && isCorrect(model))  && priceIsPositive(price);
    }

    private bool isCorrect(String value)
    {
      return !Regex.IsMatch(value, "^(\\d*|\\W*)$");
    }

    private bool priceIsPositive(double price)
    {
      return price > 0;
    }

    public string GetMark()
    {
      return mark;
    }

    public string GetModel()
    {
      return model;

    }

    public string GetType()
    {
      return type;
    }

    public double GetPrice()
    {
      return price;
    }
  }
}
