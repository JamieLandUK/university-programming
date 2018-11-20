using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w08t1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~ Acme Calculator-O-Matic ~~~~~~");

            string n1;
            string n2;

            if (args.Length > 0)
            {
                n1 = args[0];
                n2 = args[1];
            }
            else
            {
                Console.WriteLine("Enter two integers to add...");
                n1 = Console.ReadLine();
                n2 = Console.ReadLine();
            }

            try
            {
                Convert.ToInt32(n1);
                int number1 = Convert.ToInt32(n1);
                int number2 = Convert.ToInt32(n2);
                Console.WriteLine("Answer {0}", Calculator.Add(number1, number2));
            }
            catch (Exception e)
            {
                double number1 = Convert.ToDouble(n1);
                double number2 = Convert.ToDouble(n2);
                Console.WriteLine("Answer {0}", Calculator.Add(number1, number2));
            }

            Console.ReadKey();
        }

        private static int Add(int a, int b)
        {
            return (a + b);
        }

        private static double Add(double a, double b)
        {
            return (a + b);
        }
    }
}
