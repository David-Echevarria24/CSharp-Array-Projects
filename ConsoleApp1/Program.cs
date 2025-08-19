namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // Title Change, console color/text change 
        Console.Title = "Custom Quote App";
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine("Enter a quote");

        // Convert quote given by user to all uppercase
        string quote = Console.ReadLine();
        string upperQuote = quote.ToUpper();

        // Display quote center of the console
        int verticalStart = Console.CursorTop + 5;
        int horizontalStart = (Console.WindowWidth - quote.Length) / 2;
        Console.SetCursorPosition(horizontalStart, verticalStart);
        Console.WriteLine(upperQuote);
        string ackn = "Quote received";

        // Display message received center and below
        verticalStart = Console.CursorTop + 2;
        horizontalStart = (Console.WindowWidth - quote.Length) / 2;
        Console.SetCursorPosition(horizontalStart, verticalStart);
        Console.WriteLine(ackn);


        Console.ReadLine();

    }
}
