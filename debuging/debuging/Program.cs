using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace debuging
{
    class Program
    {
        static int mod (int a,int b)=>(a*b);

        static void Main(string[] args)
        {
            Debug.WriteLine("program is in main");
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Debug.WriteLine($"Entred{a} & {b} ");
            Console.WriteLine($"result { mod(a, b)}");
            Debug.WriteLine("main method Finished");

            Console.ReadLine();
        }
    }
}
