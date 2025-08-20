using System.Collections;
class Program
{
    static void Main()
    {
        BitArray bits = new BitArray(5);
 
        bits[0] = true;
        bits[2] = true;
 
        Console.WriteLine("Bit values:");
        for (int i = 0; i < bits.Count; i++)
        {
            Console.WriteLine($"Bit {i}: {bits[i]}");
        }
 
        bits.Not();
        Console.WriteLine("Bit values after NOT operation:");
        for (int i = 0; i < bits.Count; i++)
        {
            Console.WriteLine($"Bit {i}: {bits[i]}");
        }
 
    }
 
}
