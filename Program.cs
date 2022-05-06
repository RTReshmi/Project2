using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, div;
                Console.WriteLine("enter the first number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second number");
                b = Convert.ToInt32(Console.ReadLine());
                div = a / b;
                Console.WriteLine(div);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("second number should not be zero.please try again");
            }
            //finally
            //{
            //    Console.WriteLine("testing");
            //}
        }
    }
}
