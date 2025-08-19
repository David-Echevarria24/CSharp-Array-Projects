namespace DataFormatting4;

class Program
{
    static void Main(string[] args)
    {
        string data = "12345John Smith          5000  3  ";
        int startingPosition = data.IndexOf("J");
        int closingPosition = data.LastIndexOf("5");
        int length = closingPosition - startingPosition;
        data = data.Remove(startingPosition, length);
        Console.WriteLine(data.TrimEnd());
    }
}
