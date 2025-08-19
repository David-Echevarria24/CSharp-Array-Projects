namespace ConsoleApp4;

class Program
{
    static void Main(string[] args)
    {
        // We identified what var is, in this example, a string
        var message = "Hello World";
        System.Console.WriteLine(message.GetType());

        // What will var be here
        int x = 10;
        int y = 3;
        var result = x / y;
        // Var is Int

        // What will var be here
        double a = 10;
        double b = 3;
        var result2 = a / b;
        //Var is double

        // What will var be here
        int m = 10;
        double n = 3;
        var result3 = m / n;
        //Var is double



    }
}
