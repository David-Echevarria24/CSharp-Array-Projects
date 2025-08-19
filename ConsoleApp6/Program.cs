namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        // Perform the following tasks by using string interpolation:
        // Use string interpolation to combine a literal string and a variable value
        // Use string interpolation with multiple variables and literal strings
        // Avoid intermediate variables
        // Combine verbatim literals and string interpolation

        string name = "David";
        int age = 27;
        int year = 1997;
        string placeOfBirth = "West Palm Beach";
        string sonName = "Immanuel";
        
        
        Console.WriteLine($"Hello! My name is {name.ToUpper()}.\nI was born in {placeOfBirth}.\nI am {age} years old.\nThe year I was born in was {year}. \nI have one child and his name is {sonName}.");
        Console.WriteLine(@"First line 
second line");

       Console.WriteLine("Currency symbol for USD is \u0024");
 

        
    }
}
