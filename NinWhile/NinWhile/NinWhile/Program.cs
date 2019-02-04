using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinWhile
{
    class Program
    {
        static void task1(int n)
        {
            Console.WriteLine("N: " + n);
            int j = 1;
            int count = 1;

            while (j <= n / 2)
            {
                int i = 1;

                while (i <= j)
                {
                    Console.WriteLine(count + ": i = " + i + ", j = " + j);
                    count++;
                    i++;
                }
                j++;
            }

            Console.WriteLine();
            if (n == 6)
            {
                task1(8);
            }
            else if (n == 8)
            {
                task1(10);
            }
        }

        static void task2(int n)
        {
            Console.WriteLine("N: " + n);
            int count = 1;

            for (int i = 1; i <= n; i++)
            {
                int j = n;
                while (j >= 1)
                {
                    Console.WriteLine(count + ": i = " + i + ", j = " + j);
                    count++;
                    j = j / 2;
                }
            }

            Console.WriteLine();
            if (n == 4)
            {
                task2(8);
            }
            else if (n == 8)
            {
                task2(16);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (answer)
            {
                case 1:
                    task1(6);
                    break;
                case 2:
                    task2(4);
                    break;
                default:
                    break;
            }

            Main(args);
        }
    }
}
