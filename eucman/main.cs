using System;

/* Calculate and output:
 * the Euclidean Distance
 * the Manhattan Distance
 * ...between two points on a 2D plane.
 */
class Eucman {
    public double euclidean_distance (int x1, int y1, int x2, int y2) {
        double a = Math.Pow((x2 - x1), 2);
        double b = Math.Pow((y2 - y1), 2);
        double c = a + b;
        return Math.Sqrt(c);
    }

    public double manhattan_distance (int x1, int y1, int x2, int y2) {
        double a = Math.Abs(x2 - x1);
        double b = Math.Abs(y2 - y1);
        return a + b;
    }

    public static void main (string[] args) {
        Console.WriteLine("Euclidean and Manhattan distances");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Point A");
        Console.WriteLine("X: ");
        int x1 = Console.Read();
        Console.WriteLine("Y: ");
        int y1 = Console.Read();
        Console.WriteLine();
        Console.WriteLine("Point B");
        Console.WriteLine("X: ");
        int x2 = Console.Read();
        Console.WriteLine("Y: ");
        int y2 = Console.Read();

        Console.WriteLine("({0},{1}) and ({2},{3})", x1, y1, x2, y2);

        double euc_dis = euclidean_distance(x1, y1, x2, y2);
        double man_dis = manhattan_distance(x1, y1, x2, y2);

        Console.WriteLine("Euclidean distance of the two points is {0}", euc_dis);
        Console.WriteLine("Manhattan distance of the two points is {0}", man_dis);

    }
}