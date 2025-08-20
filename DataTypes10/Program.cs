namespace DataTypes10;

class Program
{
    static void Main(string[] args)
    {
        dynamic message = "Hello world";

        Console.WriteLine(message.ToUpper());


        message = 123;
        Console.WriteLine(message + 1);
    }
}
