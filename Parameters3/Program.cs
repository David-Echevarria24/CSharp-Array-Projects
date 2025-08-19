namespace Parameters3;

class Program
{
    static void Main(string[] args)
    {
        Box a = new Box(3);
        Box b = new Box(4);
        Box result = new Box(0);

        Multiply(a, b, result);
        Console.WriteLine($"Multiply Method: {a.Value} x {b.Value} = {result.Value} {result.GetHashCode()}");
    }
    static void Multiply(Box a, Box b, Box c)
    {
        c.Value = a.Value * b.Value;
        {
            Console.WriteLine($"Inside Multiple Method: {a.Value} x {b.Value} = {c.Value} {c.GetHashCode()}");
        }
    }
}
class Box
{
    public int Value;
    public Box(int value)
    {
        Value = value;
    }
}
