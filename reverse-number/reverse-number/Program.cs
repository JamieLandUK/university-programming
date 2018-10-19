using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_number
{
    class Program
    {
        static string ReverseNumber(string number)
        {
            int size = number.Length;
            char[] letters = new char[size];

            for (int i = 0; i < size; i++)
            {
                letters[i] = number[i];
            }

            int count = 0;
            char[] answer_letters = new char[size];
            for (int i = size; i > 0; i--)
            {
                answer_letters[count] = letters[i];
                count++;
            }

            string answer = string.Join(",", answer_letters);

            return answer;
        }

        public static void Main(string[] args)
        {
            Console.Write("What is the number you would like to reverse? ");
            string number = Console.ReadLine();
            Console.WriteLine(ReverseNumber(number));
        }
    }
}
