using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace messages_oop
{
    class Message
    {
        public string s = "Hello, this is a class!";

        public void DisplayMessage()
        {
            Console.WriteLine(s);
        }

        public void DisplayDate()
        {
            Console.WriteLine("Today's date is {0}!", DateTime.Now.ToString("dd/MM/yy"));
        }

        public void WriteLog(string x)
        {
            File.AppendAllText("yes.log", Environment.NewLine + DateTime.Now.ToString("dd/MM/yy: ") + x);
        }

        public string[] ReadLogFile()
        {
            string[] all_messages = File.ReadAllLines("yes.log");
            foreach (string message in all_messages)
            {
                Console.WriteLine(message);
            }
            return all_messages;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();
            message.DisplayMessage();
            message.DisplayDate();
            message.WriteLog(Console.ReadLine());
            message.ReadLogFile();  
            Console.ReadKey();
        }
    }
}
