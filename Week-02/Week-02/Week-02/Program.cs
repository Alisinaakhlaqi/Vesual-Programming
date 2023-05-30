using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            int Age;
            string Age2;
            string Name, Message;
            Name = Console.ReadLine();
            Age = int.Parse(Console.ReadLine());
            A = (Double)Age;
            A = Convert.ToDouble(Age);
            Age2 = Convert.ToString(Age);
            A = double.Parse(Age2);
            Age = Convert.ToInt32(Console.ReadLine());
            //A = (int)Age;
            Message = " Your name is " + Name + " And You Are " + Age + " years old ";
            Console.Write(" print text by type 1 :");
            Console.WriteLine(Message);

            Console.ReadLine();

        }
    }
}
