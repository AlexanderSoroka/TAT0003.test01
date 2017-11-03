using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Task2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Collection<int> collection = new Collection<int>();

                Random random = new Random();

                for (var i = 0; i < random.Next(0, 100); i++)
                {
                    collection.Add(random.Next(0, 10));
                }

                for (var i = 0; i < collection.Count - 1; i++)
                {
                    if (collection[i] > collection[i + 1])
                    {
                        var buff = collection[i];
                        collection[i] = collection[i + 1];
                        collection[i + 1] = buff;
                    }
                }

                var elem = collection[0];
                int coun = 1;
                StringBuilder stringBuilder = new StringBuilder();
                for (var i = 1; i < collection.Count; i++)
                {
                    if (elem == collection[i])
                    {
                        coun++;
                    }
                    else
                    {
                        if (coun > 1)
                        {
                            Console.WriteLine("There are " + coun + " elements " + elem);
                        }
                        coun = 1;
                        elem = collection[i];
                    }
                }
                if (coun > 0)
                {
                    Console.WriteLine("There are " + coun + " elements " + elem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
