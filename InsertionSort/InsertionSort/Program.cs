using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static int[] Insertion(int[] data)
        {
            int numSorted = 1;
            int index;
            int count = 0;

            while (numSorted < data.Length)
            {
                int temp = data[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    if (temp < data[index - 1])
                    {
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        break;
                    }
                }

                data[index] = temp;
                numSorted++;

                count++;
            }

            Console.WriteLine("Count: " + count);
            return data;
        }

        static void Main(string[] args)
        {
            int[] input1 = { 123, 34, 189, 56, 150, 12, 9, 240 };
            int[] input2 = { 92, 471, -49, 340, 286, 406, 127, 352,
407, 78, 225, 499, 224, 83, 269, -103, 356, 137, -187, 317, 495, 82, 409,
345, 483, -108, 100, 296, 52, 19, 327, 272 };

            int[] a = Insertion(input1);
            foreach (var number in a)
            {
                Console.Write(number + " ");
            }

            int[] b = Insertion(input2);
            foreach (var number in b)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
