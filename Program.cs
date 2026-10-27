using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorApp
{
    internal class Program
    {
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Subtracting 5 - 3 gives {Subtract(5, 3)}");
        }
    }
}
