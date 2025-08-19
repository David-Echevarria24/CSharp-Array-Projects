namespace Parameters2;

class Program
{
    static void Main(string[] args) 
    {
        int a = 3;
        int b = 4;
        int c = 0;

        // Add multiply method
        Multiply(a, b, ref c);
        Console.WriteLine($"Applying Multiply method: {a} x {b} = {c}");
    }
    static void Multiply(int a, int b, ref int c)
    {
        c = a * b;
        Console.WriteLine($"Inside multiply method: {a} x {b} = {c}");
    }
}
