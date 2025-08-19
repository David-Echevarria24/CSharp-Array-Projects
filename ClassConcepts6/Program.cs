namespace ClassConcepts6;

class Program
{
    static void Main(string[] args) {


        Box boxA = new Box(3);
        Box boxB = new Box(4);
        Box result = new Box(0);

        Multiply(boxA, boxB, result);
        Console.WriteLine($"global statement: {boxA.Value} x {boxB.Value} = {result.Value}");
    }

    static void Multiply(Box a, Box b, Box c)
    {
        c.Value = a.Value * b.Value;
        Console.WriteLine($"inside Multiply method: {a.Value} x {b.Value} = {c.Value}");
    }


    class Box
    {
        public int Value;
        public Box(int value)
        {
            Value = value;
        }
    }
}