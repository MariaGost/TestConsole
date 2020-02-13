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

            double x = double.Parse(x_str);
            double y = double.Parse(y_str);

            double z = x / y;

            Console.WriteLine($"{x} / {y} = {z:F18}");
            Console.ReadLine();
        }
    }
}
