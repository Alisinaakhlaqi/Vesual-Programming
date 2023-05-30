using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOpertor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            Console.WriteLine("Enter your Age");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" You Are " + ((Age > 30) && (Age > 20)) + " Young");
            Console.WriteLine(" You Are " + ((Age < 30) && (Age < 50 )) + " Midle Man");
            Console.WriteLine(" You Are " + ((Age == 30) || (Age<=20) || (Age>=50)) + " Comment");
            Console.ReadLine();
        }
    }
}
