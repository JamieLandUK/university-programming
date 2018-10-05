using System;

class MainClass {
    // Using the exclusive OR gate function
    public static void XORSwap (int a, int b) {
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
        Console.WriteLine("A = {0}", a);
        Console.WriteLine("B = {0}", b);
        Main();
    }

    // You can use tuples to swap variables
    public static void TupleSwap (int a, int b) {
        (a, b) = (b, a);
        Console.WriteLine("A = {0}", a);
        Console.WriteLine("B = {0}", b);
        Main();
    }

    public static void Main (string[] args) {
        int a = 10;
        int b = 2;
        Console.WriteLine("A = {0}", a);
        Console.WriteLine("B = {0}", b);
        Console.WriteLine();
        TupleSwap(a, b);
        Console.WriteLine();
        XORSwap(a, b);
    }
}