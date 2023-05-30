using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transcript
{
    class Program
    {
        static void Info (ref int []a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void print(string s)
        {
            int l = s.Length;
            int pl = (1 / 2) + s.Length;
            s = s.PadLeft(pl, ' ');
            s = s.PadRight(12, ' ');
        }
        static double AVG(int[] s, int[] c)
        {
            int m = 0;
            for (int i =0; i<s.Length; i++)
            {
                m = m + (s[i] * c[i]);
            }
            return (double)m / s.Length;
        }
        static void Main(string[] args)
        {
            string[] Lessons = new string[3];
            for (int i = 0; i < Lessons.Length; i++)
            {
                Lessons[i] = Console.ReadLine();
            }
            int[] score = new int[3];
            int [] credit = new int[3];
            double Avg;
            Info(ref score);
            Info(ref credit);

            Avg = AVG(score, credit);
            string ver = "-";
            string hor = "|";

            hor = hor.PadLeft(12, ' ');
            Console.WriteLine(ver);
            string l = "lessons", s = "score", c = "credit";
            l = l.PadLeft(9, ' ');
            l = l.PadRight(12, ' ');
            Console.WriteLine(l);
            Console.Write(hor);

            s = s.PadLeft(8, ' ');
            s = s.PadRight(12, ' ');
            Console.WriteLine(s);

            c = c.PadLeft(9, ' ');
            c = c.PadRight(12, ' ');
            Console.WriteLine(c);

            for(int i = 0; i < Lessons.Length; i++)
            {
                print(Lessons[i]);
                Console.Write(hor);
                print(Convert.ToString(score[i]));
                Console.Write(hor);
                print(Convert.ToString(credit[i]));
                Console.WriteLine(hor);
                Console.WriteLine(ver);
            }
            Console.ReadLine();
        }
    }
}
