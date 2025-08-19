using System.Reflection;

namespace ClassConcepts4;

class Program
{
    static void Main(string[] args)
    {
        
    }
}
public class ExampleClass
{

    public int Property1 { get; set; }
    public string Property2 { get; set; }

    public ExampleClass(int property1, string property2)
    {

        Property1 = property1;
        Property2 = property2;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Property1: {Property1}, Property2: {Property2},");
    }
}

