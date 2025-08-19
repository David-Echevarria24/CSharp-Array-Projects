namespace Parameters6;

class Program
{
    static void Main(string[] args)
    {
        Box boxA = new Box("3");
        Box boxB = new Box("4");
        Box result = new Box("0");

        Multiply(boxA, boxB, result);
        Console.WriteLine($"Mutiply Method: {boxA.Value} x {boxB.Value} = {result.Value}");
    }

    static void Multiply(Box a, Box b, Box c)
    {
        c.Value = (int.Parse(a.Value) * int.Parse(b.Value)).ToString();
        Console.WriteLine($"Inside Mutiply Method: {a.Value} x {b.Value} = {c.Value}");
    }
}
class Box
{
    public string Value;
    public Box(string value)
    {
        Value = value;
    }
}