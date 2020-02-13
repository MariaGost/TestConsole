using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number x > ");
            string x_str = Console.ReadLine();
            Console.Write("Enter number y > ");
            string y_str = Console.ReadLine();

            int x = int.Parse(x_str);
            int y = int.Parse(y_str);

            int z = x + y;

            Console.WriteLine($"{x} + {y} = {z}");
            Console.ReadLine();
        }
    }
}
