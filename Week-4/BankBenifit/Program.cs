using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBenifit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Blance, BlanceGold, BankBenifit;
            int mounthWait;
            Console.WriteLine("Enter Blance :");
            Blance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Gold :");
            BlanceGold = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Bank Benifit :");
            BankBenifit = Convert.ToDouble(Console.ReadLine());
            mounthWait = 0;
            while (Blance <= BlanceGold)
            {
                Blance = (Blance * (BankBenifit / 100)) + Blance;
                mounthWait++;
                Console.WriteLine("Your Blance After: \t" + mounthWait + "\t is \t" + Blance);

            }
          

            Console.WriteLine("Number of mounth they you should waite is \t" + mounthWait);
            Console.ReadLine();
        }
    }
}
