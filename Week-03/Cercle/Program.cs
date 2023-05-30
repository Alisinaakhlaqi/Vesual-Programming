using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cercle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, diameter, area, premater;
            const double Pi = 3.14;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\tEnter radius:");
            radius = float.Parse(Console.ReadLine());
            diameter = radius * 2;
            premater = diameter * Pi;
            area = radius * radius * Pi;
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\t ========================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\t Radius={0}", radius);
            Console.Write("\n\t Diameter={0}", diameter);
            Console.Write("\n\t Pi = {0}", Pi);
            Console.Write("\n\t perimeter", premater);
            Console.Write("\n\t Area", area);
            Console.ReadKey();
        }
    }
}
