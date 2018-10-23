using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace montecarlopi
{
    class Program
    {
        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return a;
            else
                return b;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            double x;
            double y;
            int hits = 0;
            int throws = 0;

            for (int i = 0; i < 100000; i++)
            {
                x = random.NextDouble();
                y = random.NextDouble();

                if (x * x + y * y <= 1)
                {
                    hits += 1;
                }
                throws += 1;
            }

            var gcd = GCD(hits, throws);

            double approx = ((throws / gcd) / (hits / gcd)) * 4;

            Console.WriteLine($"{hits} hits in {throws} throws.");
            Console.WriteLine("Approximation of pi = {0}.", approx);
            Console.ReadKey();
        }
    }
}
