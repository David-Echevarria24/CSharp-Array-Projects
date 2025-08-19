namespace Constance1;

class Program
{
    const decimal TaxRate = 0.075m;
    static void Main(string[] args)
    {
        var e1 = new Example();
        var e2 = new Example();

        Console.WriteLine($"e1.Id : {e1.Id}");
        Console.WriteLine($"e2.Id : {e2.Id}");
    }
}

public class Example
{
    public readonly Guid Id = Guid.NewGuid();
    public Example()
    {
        
    }
}