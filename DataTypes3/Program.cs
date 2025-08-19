using System.Diagnostics.Metrics;
using System.Dynamic;

namespace DataTypes3;

class Program
{
    static int counter = 0;
    static void Main(string[] args)
    {

        Recurse();

    }

    static void Recurse()
    {
        int x = counter++;
        Console.WriteLine($"Recursion depth: {x}");
        // Thread.Sleep(1);
        Recurse();
    }
}
