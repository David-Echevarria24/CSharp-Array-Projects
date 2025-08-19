using System.Runtime.Serialization;

namespace DataTypes1;

class Program //A class calls the next reference. Struct memory is saved to the original p1.X in this example
{
    static void Main(string[] args)
    {
        Point p1 = new Point();
        p1.X = 7;

        Point p2 = p1;
        Console.WriteLine($"p1.X is equal to {p1.X}.");
        Console.WriteLine($"p2.X is equal to {p2.X}.");
        p1.X = 9;
        Console.WriteLine($"p1.X is equal to {p1.X}.");
        Console.WriteLine($"p2.X is equal to {p2.X}.");
    }
}

// public struct Point
// {
//     public int X, Y;
// }

public class Point
{
    public int X, Y;
}