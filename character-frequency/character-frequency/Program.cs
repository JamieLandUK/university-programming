using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character_frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give a phrase: ");
            string words = Console.ReadLine();
            string phrase = words.ToLower();

            bool loop = true;

            while (loop)
            {
                Console.Write("Input a letter to see frequency: ");
                char letter = Char.ToLower(Convert.ToChar(Console.ReadLine()));
                int count = 0;

                foreach (var part in phrase)
                {
                    if (part == letter)
                    {
                        count++;
                    }
                }

                Console.WriteLine("There are {0} {1}'s in the phrase.", count, letter);
                Console.ReadKey();
            }
        }
    }
}
