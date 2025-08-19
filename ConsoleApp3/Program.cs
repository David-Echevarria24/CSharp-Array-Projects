namespace ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        // Exercise to declare variable
        int myVariable;
        myVariable = 10;
        Console.WriteLine(myVariable);


        // Assigned value into a new variable. Declared old variable with a new value
        int newNumber = myVariable;
        myVariable = 11;

        // Now it should read 10,10,11 
        Console.WriteLine(newNumber);
        Console.WriteLine(myVariable);


        






        Console.ReadLine();
    }
}
