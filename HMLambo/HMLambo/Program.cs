using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMLambo
{
    class Program
    {
        int a, b;
        static int sum(int a, int b) => a + b;
        static int Min(int a, int b) => a - b;
        static int muly(int a, int b) => a * b;
        static double div(double a, double b) => Convert.ToDouble(a / b);
        static void Main(string[] args)
        {
            Console.WriteLine(sum(5, 6));
            Console.WriteLine(Min(6, 4));
            Console.WriteLine(muly(2, 2));
            Console.WriteLine(div(10, 3));
            Console.ReadLine();
        }
    }
}
