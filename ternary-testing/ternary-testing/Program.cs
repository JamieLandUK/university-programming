using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string s_num1 = Console.ReadLine();
            int num1 = Convert.ToInt32(s_num1);
            Console.Write("Please enter another number: ");
            string s_num2 = Console.ReadLine();
            int num2 = Convert.ToInt32(s_num2);

            bool pos_num1 = (num1 > 0) ? true : false;
            if (pos_num1)
            {
                Console.WriteLine("Number 1 is positive.");
            }
            else
            {
                Console.WriteLine("Number 1 is negative.");
            }

            bool pos_num2 = (num2 > 0) ? true : false;
            if (pos_num2)
            {
                Console.WriteLine("Number 2 is positive.");
            }
            else
            {
                Console.WriteLine("Number 2 is negative.");
            }

            if (num1 > num2)
            {
                Console.WriteLine("Number 1 is larger.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Number 2 is larger.");
            }
            else
            {
                Console.WriteLine("Both numbers are the same.");
            }

            Console.ReadKey();
        }
    }
}
