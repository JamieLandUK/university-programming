using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace readinglog
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] messages = File.ReadAllLines("logfile.log");
            DateTime[] reboots = new DateTime[messages.Length];
            DateTime[] times = new DateTime[messages.Length];

            for (int i = 0; i < messages.Length; i++)
            {
                if (messages[i].Contains("System reboot")) {
                    DateTime parsed_date;
                    parsed_date = DateTime.Parse(messages[i].Substring(1, 17));
                    reboots[i] = parsed_date;
                    Console.WriteLine(parsed_date);
                }

                if (messages[i].Substring(11, 8) == "10/10/17")
                {
                    times[i] = DateTime.Parse(messages[i].Substring(1, 8));
                }
            }

            int h_duration = (times[0] - times[1]).Hours;
            int m_duration = (times[0] - times[1]).Minutes;
            int s_duration = (times[0] - times[1]).Seconds;
            Console.WriteLine(h_duration + m_duration + s_duration);
            Console.ReadLine();
        }
    }
}
