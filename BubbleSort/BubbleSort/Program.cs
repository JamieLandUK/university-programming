using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static int[] BubbleSort(int[] a, int n)
        {
            int count = 0;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1-i; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                    count++;
                }
            }
            Console.WriteLine("Amount of operations: " + count);
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort");
            bool loop = true;
            int length = 1;
            List<int> numbers = new List<int>();
            while (loop)
            {
                Console.Write(length + ": ");
                string temp = Console.ReadLine();
                if (temp == "x")
                {
                    loop = false;
                    break;
                }
                numbers.Add(Convert.ToInt32(temp));
                length++;
            }
            int[] a = numbers.ToArray();
            Console.Write("Old: [");
            foreach (var number in a)
            {
                Console.Write(number.ToString() + ", ");
            }
            Console.Write("]");
            Console.WriteLine();
            int[] b = BubbleSort(a, a.Length);
            Console.Write("Sorted: [");
            foreach (var number in b)
            {
                Console.Write(number.ToString() + ", ");
            }
            Console.Write("]");
            Console.ReadKey();
        }
    }
}
