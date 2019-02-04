using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeComplexity
{
    class Program
    {
        static void Question1(int n)
        {
            Console.WriteLine();
            Console.WriteLine("n = {0}", n);
            Console.WriteLine("for(i = 1; i <= 1.5 * n; i++)");
            int count = 1;
            for (int i = 1; i <= 1.5 * n; i++)
            {
                Console.WriteLine(count + ": " + i);
                count++;
            }

            Console.WriteLine();
            Console.WriteLine("for(i = n; i >= 1; i--)");
            count = 1;
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(count + ": " + i);
                count++;
            }

            if (n == 2)
            {
                Question1(4);
            } 
            else if (n == 4)
            {
                Question1(6);
            }

            Console.WriteLine();
        }

        static void Question2(int n)
        {
            Console.WriteLine();
            Console.WriteLine("n = {0}", n);
            Console.WriteLine("for(i = 2; i <= n; i++) \n\t for(j = 0; j <= n;) {\n\t\t j = j + (n / 4)\n\t}\n}");
            int count = 1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j <= n;)
                {
                    Console.WriteLine("{0}: {1}, {2}", count, i, j);
                    j = j + (n / 4);
                    count++;
                }
            }

            if (n == 4)
            {
                Question2(16);
            }
            if (n == 16)
            {
                Question2(32);
            }

            Console.WriteLine();
        }

        static void Question3()
        {
            int[] a = { 0, 2, 5, 3, 7, 8 };
            Console.WriteLine(AddThem(5, a));
        }

        static int AddThem(int n, int[] a)
        {
            int count = 1;


            int j = 0;
            for (int i = 1; i <= n; i++)
            {
                j = j + a[i];
                count++;
            }

            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                k += k;
                count++;
            }

            Console.WriteLine(count);
            return j + k;
        }

        static void Main(string[] args)
        {
            Console.Write("Menu - type a number: ");
            int menu_answer = Convert.ToInt32(Console.ReadLine());

            switch (menu_answer)
            {
                case 1:
                    Question1(2);
                    break;
                case 2:
                    Question2(4);
                    break;
                case 3:
                    Question3();
                    break;
                default:
                    break;
            }

            Main(args);
        }
    }
}
