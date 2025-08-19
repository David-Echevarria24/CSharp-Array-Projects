namespace ClassConcepts5;

class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = 4;
        int c = 0;

        Multiply(a, b, ref c);
        Console.WriteLine($"global statement: {a} x {b} = {c}");

        void Multiply(int a, int b, ref int c)
        {
            c = a * b;
            Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
        }
    }
}
