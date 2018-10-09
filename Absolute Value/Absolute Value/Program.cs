using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolute_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Console.Read();
            int answer;

            answer = (num < 0) ? -num : num;
            Console.WriteLine("The absolute value is {0}", answer);
            Console.ReadKey();
        }
    }
}
