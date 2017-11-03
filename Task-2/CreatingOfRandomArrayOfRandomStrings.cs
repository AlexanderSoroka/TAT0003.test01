using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
  class CreatingOfRandomArrayOfRandomStrings
  {
    private Random random = new Random(DateTime.Now.Millisecond);

    /// <summary>
    /// Creates random string.
    /// </summary>
    /// <returns>Returns random string.</returns>
    private string getRandomString()
    {
      int lengthText = random.Next(1, 10);
      StringBuilder text = new StringBuilder(lengthText);
      for (int i = 0; i < lengthText; i++)
      {
        text.Append((char)random.Next(97, 123));
      }
      return text.ToString();
    }

    public List<string> CreateRandomArrayOfRandomStrings()
    {
      List<string> randomArrayOfRandomStrings = new List<string>();
      for (int i = 0; i < random.Next(1, 10); i++)
      {
        randomArrayOfRandomStrings.Add(getRandomString());
      }
      return randomArrayOfRandomStrings;
    }
  }
}
