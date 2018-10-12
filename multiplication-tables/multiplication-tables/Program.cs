using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication tables");
            Console.Write("What number would you like to see? ");
            string s_top_num = Console.ReadLine();
            int top_num = Convert.ToInt32(s_top_num);
            Console.Write("Second number? ");
            string s_times_num = Console.ReadLine();
            int times_num = Convert.ToInt32(s_times_num);

            for (int i = 1; i < times_num+1; i++)
            {
                Console.WriteLine($"{top_num} * {i} = {top_num * i}");
            }

            Console.WriteLine();
            Main(args);
        }
    }
}
