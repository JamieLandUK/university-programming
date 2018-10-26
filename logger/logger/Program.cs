using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What text would you like to write to the log? ");
            string text = Console.ReadLine();

            IEnumerable<string> answer = new string[1];
            answer.Concat(new string[] { $"[{DateTime.Now} -> {text}]" });

            File.AppendAllLines("today.log", answer);
        }
    }
}
    