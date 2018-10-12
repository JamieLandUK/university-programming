using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_nums_3to17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            while (i >= 3)
            {
                if (i == 9)
                    goto Goodboy;

                if (i == 19)
                    break;
                else if (i > 19)
                {
                    Console.WriteLine("Missed");
                    break;
                }

                Console.WriteLine($"{i}");

            Goodboy:
                i += 2;
            }

            Console.ReadKey();
        }
    }
}
