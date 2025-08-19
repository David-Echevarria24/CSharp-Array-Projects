namespace ConsoleApp8;

class Program
{
    static void Main(string[] args)
    {
       // Converting implicit data types
       char letter = 'a';
       System.Console.WriteLine(letter);
       int number = letter;
       System.Console.WriteLine(number);
       letter = (char)99;
       System.Console.WriteLine(letter);
       System.Console.WriteLine(Convert.ToInt16(letter));
    }
}
