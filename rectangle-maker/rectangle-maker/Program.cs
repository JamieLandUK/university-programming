using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Character: ");
            string s_character = Console.ReadLine();
            char character = Convert.ToChar(s_character);
            Console.Write("Width: ");
            string s_width = Console.ReadLine();
            int width = Convert.ToInt32(s_width);
            Console.Write("Height: ");
            string s_height = Console.ReadLine();
            int height = Convert.ToInt32(s_height);
            Console.WriteLine();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
