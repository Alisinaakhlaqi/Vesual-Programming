using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static int Get_number()
        {
            Console.WriteLine("enter int number = ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            try
            {

                int a = Get_number();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("program finished");
            }
            Console.ReadLine();

        }
    }
}
