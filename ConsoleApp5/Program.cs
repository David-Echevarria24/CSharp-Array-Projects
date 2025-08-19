namespace ConsoleApp5;

class Program
{
    static void Main(string[] args)
    {   

        // Exercise. Use the following given variables.
        //  Then, use multiple Console.Write statements to out put the message Hello Bob! You have 3 message(s) in your inbox,The temperature is 34.4 Celsius.
        string name = "Bob";
        int message = 3;
        decimal temp = 34.4m;

        Console.Write("Hello " + name + "! ");
        Console.Write("You have " + message + " message(s) in your inbox,");
        Console.Write("The temperature is " + temp + " Celsius.");

    }
}
