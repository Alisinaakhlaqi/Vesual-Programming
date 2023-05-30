using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[][] trs;
            //string[][] trs = new string[3][];
            //string[][] trs = new string[3][] { new string[3],new string[5],new string[4]};
            //string[][] trs = { new string[3] { "ac", "kl", "pl" }, new string[1] { "45" }, new string[2] { "4f", "34" } };
            int[][,] a = new int[4][,];
            a[0] = new int[3,2];
            a[1] = new int[5,1];
            a[2] = new int[1,1];
            a[3] = new int[2,2];
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter numbers");
                for(int j = 0; j < a[i].GetLength(0); j++)
                {
                    for(int h=0;h<a[i].GetLength(1); h++)
                    {
                        a[i][j,h] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            int k = 0;
            foreach(int[,]x in a)
            {
                Console.Write($"a[{k}] = ");
                int Count_Clm = 0;
                foreach( int y in x)
                {
                    if (Count_Clm == x.GetLength(1))
                    {
                        Console.WriteLine();
                        Count_Clm = 0;
                    }
                    Console.Write(y + "\t");
                    Count_Clm++;
                }
                k++;
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
