using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            char op;
               
            Console.Write("Inter First Number : ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inter First Number : ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inter First Opertor : ");
            op = Convert.ToChar(Console.ReadLine());
            //if (op == '+')
            //    Console.WriteLine(A + B);
            //else if (op == '-')
            //    Console.WriteLine(A - B);
            //else if (op == '*')
            //    Console.WriteLine(A * B);
            //else if (op == '/')
            //    Console.WriteLine(A / B);
            //else
            //    Console.WriteLine("ERROR");
            
            switch(op){
                case '+':
                    {
                        Console.WriteLine(A + B);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(A - B);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(A * B);
                        break;
                    }
                case '/':
                    {
                        if()
                        Console.WriteLine(A / B);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("ERROR");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
