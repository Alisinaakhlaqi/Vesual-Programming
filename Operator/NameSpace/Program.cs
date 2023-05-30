using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameSpace2;
using static System.Console;

namespace NameSpace1
{
    class C1
    {
        public void F1()
        {
            WriteLine("You Are in \" Namespace 1\" and class \"C1\" And Function \"F1\"");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C1 obj = new C1();
            NameSpace2.C1 obj2 = new NameSpace2.C1();
            obj.F1();
            obj2.F1();
            Console.ReadLine();
            //string ans;
            //Console.WriteLine("Enter your ans");
            //ans = Console.ReadLine();
            //A.print(ans);
            //Console.ReadLine();
        }
    }
}
namespace NameSpace2
{
    //class A
    //{
    //    static public void print(string x)
    //    {
    //        Console.WriteLine(x);
    //    }
    //}
    class C1
    {
        public void F1()
        {
            Console.WriteLine("You Are in \" Namespace 2\" and class \"C1\" And Function \"F1\"");
        }
    }
}
