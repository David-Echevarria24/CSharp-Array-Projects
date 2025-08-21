using System.Collections;

namespace Generic2;

class Program
{
    static void Main(string[] args)
    {
        ArrayList ngNumbers = new ArrayList();
        ngNumbers.Add(10);
        int nGx = (int)ngNumbers[0];
        Console.WriteLine($"ngX is {nGx}");


        List<int> gNumbers = new List<int>();
        gNumbers.Add(20);
        int gX = gNumbers[0];
        Console.WriteLine($"gX is {gX}");
    }
}
