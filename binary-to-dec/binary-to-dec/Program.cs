using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_to_dec
{
    class Program
    {
        static int BinToDec(string input)
        {
            // I need to separate the string into the single letters (or numbers)
            char[] array = input.ToCharArray();

            /* Flip the array as binary works as ...32, 16, 8, 4, 2, 1
             * and I want to be able to access the units first easily.
             */
            Array.Reverse(array);
            // Base sum to keep track of all what is inside the for loop.
            int sum = 0;

            // Going through every number.
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    /* If the first number (the units) of the binary is 1,
                     * It will only need to be given that single 1.
                     */
                    if (i == 0)
                    {
                        sum += 1;
                    }
                    /* However, if it is anything outside of the units column.
                     * Cast the number to an int so that I can get it to the power
                     * of the column.
                     */
                    else
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }
            }

            // Give it back to the user.
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("What is the binary number you want the decimal of? ");
            string number = Console.ReadLine();
            Console.WriteLine($"The decimal of {number} is {BinToDec(number)}.");
            Console.ReadKey();
        }
    }
}
