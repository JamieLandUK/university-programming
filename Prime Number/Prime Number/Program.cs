using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string s_num = Console.ReadLine();
            int num = Int32.Parse(s_num);

            // Work around so 1 isn't caught later.
            if (num == 2)
            {
                Console.WriteLine("2 is a prime number");
                Console.ReadKey();
                Environment.Exit(0);
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                { 
                    Console.WriteLine("{0} is not a prime number", num);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("{0} is a prime number", num);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}
