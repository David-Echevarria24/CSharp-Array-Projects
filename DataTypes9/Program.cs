namespace DataTypes9;

class Program
{
    static int Add(int x, int y) => x + y;
    static int Multiply(int x, int y) => x * y;
    static int Subtract(int x, int y) => x - y;
    static void Main(string[] args)
    {
        Calculator calc;

        Console.Write("Enter operation (add, multiply, or subtract):");
        string input = Console.ReadLine();

        calc = (input.ToLower()) switch
        {
            "add" => Add,
            "multiply" => Multiply,
            "Subtract" => Subtract,
            _ => throw new InvalidOperationException("Invalid Operator")
        };
        
        if (input == "add")

            calc = Add;
        else
            calc = Multiply;

        int result = calc(3, 4);
        Console.Write($"Result: {result}");
    }
    
}

public delegate int Calculator(int a, int b);
