using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Please press the enter button twice and this will tell you the time between them");
    Console.ReadLine();
    DateTime time1 = DateTime.Now;
    Console.WriteLine(time1);
    Console.ReadLine();
    DateTime time2 = DateTime.Now;
    Console.WriteLine(time2);
    TimeSpan between = time2 - time1;
    Console.WriteLine(between);
  }
}