using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functiom_01
{
    class Program
    {
        static void Volume(int High, int lenght, int wight){
            Console.WriteLine("volume is = " + High * 1 * wight);
        }
        static int Area(int high, int length, int wight)
        {
            int area = ((1*high)*2)+((1 * wight) * 2) + ((high * wight) * 1);
            return area;
        }
        static int paremeter  (int high, int linght, int wigth)
        {
            return 0;
        }
        static void Main(string[] args)
        {
            int hight, lenth, width;
            Console.WriteLine("please Enter dimantions");
            Console.Write("higth = ");
            hight = Convert.ToInt32(Console.ReadLine());
            Console.Write("lengh = ");
            lenth = Convert.ToInt32(Console.ReadLine());
            Console.Write("width = ");
            width = Convert.ToInt32(Console.ReadLine());
        }
    }
}
