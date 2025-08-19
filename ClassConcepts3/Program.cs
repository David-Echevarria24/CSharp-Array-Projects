namespace ClassConcepts3;

class Program //Overload methods
{
    static void Main(string[] args)
    {
        Printer printer = new Printer(); //Declared instance print with the printer class we created
        printer.Print();
        printer.Print("Hello World");
        printer.Print("Hello World", "Printed your file");



        // Random dice = new Random();
        // Console.WriteLine(dice.Next(1, 5)); //Instance based method. Non static

        // Random m1 = new Random();
        // int number1 = m1.Next();
        // int number2 = m1.Next(5);
        // int number3 = m1.Next(1, 7);
        // Console.WriteLine(number3);

    }
}

class Printer //Making our printer class
{
    public void Print()
    {

        Console.WriteLine("Nothing to print");
    }


    public void Print(string message)
    {
        Console.WriteLine($"Printing mesaage: {message}");
    }



    public void Print(string message, string extraNote)
    {
        Console.WriteLine($"Printing message {message}");
        Console.WriteLine($"Note: {extraNote}");


    }
}