using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            const string helpLine = "Push ESP to exit. Push any key to continue";
            Console.WriteLine(helpLine);
            ConsoleKeyInfo exitKey = Console.ReadKey();
            List<Automobile> autoList = new List<Automobile>(10);
            AutomobileInfo autoInfo;
            Automobile auto;       
            
            while ( exitKey.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Set automobile mark: ");
                autoInfo.Mark = Console.ReadLine();
                Console.WriteLine("Set automobile model: ");
                autoInfo.Model = Console.ReadLine();
                Console.WriteLine("Set automobile type: ");
                autoInfo.Type = Console.ReadLine();
                Console.WriteLine("Set automobile price: ");
                try
                {
                    autoInfo.Price = Double.Parse(Console.ReadLine());
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Number is not valid");
                    break;
                }
                
                auto = new Automobile(autoInfo);
                autoList.Add(auto);
                Console.WriteLine(helpLine);
                exitKey = Console.ReadKey();           
            }

            
            autoList.Sort(new PriceComparer());
            Console.WriteLine("By price:");
            foreach ( var value in autoList)
            {
                Console.WriteLine(value);
            }
            autoList.Sort(new TypeComparer());
            Console.WriteLine("By type:");
            foreach (var value in autoList)
            {
                Console.WriteLine(value);
            }
            autoList.Sort(new MarkComparer());
            Console.WriteLine("By mark:");
            foreach (var value in autoList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
