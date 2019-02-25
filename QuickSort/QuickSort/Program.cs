using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        public static double[] QuickSort(double[] data, int left, int right)
        {
            int i, j;
            double pivot, temp;

            i = left;
            j = right;
            pivot = data[(left + right) / 2];

            do
            {
                DisplayList(data);
                while ((data[i] < pivot) && (i < right))
                {
                    i++;
                }

                while ((pivot < data[j]) && (j > left))
                {
                    j--;
                }

                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j)
            {
                QuickSort(data, left, j);
            }
            if (i < right)
            {
                QuickSort(data, i, right);
            }

            return data;
        }

        public static int[] QuickSort(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;

            i = left;
            j = right;
            pivot = data[(left + right) / 2];

            do
            {
                DisplayList(data);
                while ((data[i] < pivot) && (i < right))
                {
                    i++;
                }

                while ((pivot < data[j]) && (j > left))
                {
                    j--;
                }

                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j)
            {
                QuickSort(data, left, j);
            }
            if (i < right)
            {
                QuickSort(data, i, right);
            }

            return data;
        }

        public static void DisplayList(int[] a)
        {
            foreach (int number in a)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void DisplayList(double[] a)
        {
            foreach (double number in a)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] myArray_1 = { -45, -91, -81, 65, 39, -37, 90, -94 };
            int[] myArray_2 = { -12, -24, 53, 59, -63, -2, -11, 29, 42, 51, -45, 36, 31, -68, -77, 0, 92, -32, 17, -56, 51, -49, 1, 40, 79, 92, 9, -73, -70, -49, 68, -9 };
            double[] myArray_3 = { 25.1573, 5.1437, 8.1421, 3.1625, 12.3187, 2.8465, 78.0454, -32.6666, -51.9204, -31.9391, -30.6136, -12.1411, -4.7172, -6.1189, 15.1574, 10.8995, 21.0344, 49.7912 };
            double[] myArray_4 = { -56.6149, -27.4997, 17.1503, -1.5368, -31.3245, -17.5386, 6.9865, -27.8045, 27.2986, -17.9399, 50.6482, -30.2363, 5.5773, -42.5887, -20.2617, -16.6110, 11.2374, 26.3797, 8.4136, -10.4460, 22.8337, 22.3688, 3.3657, 15.9949, 11.5583, -27.6349, 21.2679, -18.4016, -16.9097, 4.9545, -8.6101, -3.6910};

            Console.Write("List 1: ");
            DisplayList(myArray_1);
            int[] list1 = QuickSort(myArray_1, 0, myArray_1.Length - 1);
            Console.Write("Sorted: ");
            DisplayList(list1);
            Console.WriteLine();

            Console.Write("List 2: ");
            DisplayList(myArray_2);
            int[] list2 = QuickSort(myArray_2, 0, myArray_2.Length - 1);
            Console.Write("Sorted: ");
            DisplayList(list2);
            Console.WriteLine();

            Console.Write("List 3: ");
            DisplayList(myArray_3);
            double[] list3 = QuickSort(myArray_3, 0, myArray_3.Length - 1);
            Console.Write("Sorted: ");
            DisplayList(list3);
            Console.WriteLine();

            Console.Write("List 4: ");
            DisplayList(myArray_4);
            double[] list4 = QuickSort(myArray_4, 0, myArray_4.Length - 1);
            Console.Write("Sorted: ");
            DisplayList(list4);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
