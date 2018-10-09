using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler_problem_six
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum_of_square_total = 0;
            // Sum of the squares
            for (int i = 1; i <= 100; i++)
            { 
                sum_of_square_total += Math.Pow(i, 2);
                Console.WriteLine(sum_of_square_total);
            }
            Console.WriteLine();

            double square_of_sum_total = 0;
            // Square of the sum
            for (int j = 1; j <= 100; j++)
            {
                square_of_sum_total += j;
                Console.WriteLine(square_of_sum_total);
            }
            square_of_sum_total = Math.Pow(square_of_sum_total, 2);
            Console.WriteLine(square_of_sum_total);

            double answer = square_of_sum_total - sum_of_square_total;
            Console.WriteLine("The difference is {0}", answer);
            Console.ReadKey();
        }
    }
}
