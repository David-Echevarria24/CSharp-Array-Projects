namespace DataFormatting5;

class Program
{
    static void Main(string[] args)
    {
        string message = "This--is--ex-amp-le--da-ta";
        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.WriteLine(message);
    }
}
