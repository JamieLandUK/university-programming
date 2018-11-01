using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace xml_writing
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lines = new ArrayList();
            int count = 0;
            while (true) {
                count++;
                lines.Add(File.ReadLines("students.xml"));
                Console.WriteLine(lines[count-1]);
                if (lines[count-1] == "")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
