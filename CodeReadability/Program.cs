namespace CodeReadability;

class Program
{
    static void Main()
    {
        string message = "The quick brown fox jumps over the lazy dog.";
        // convert the message into a char array
        char[] messageConvert = message.ToCharArray();
        // Reverse the chars
        Array.Reverse(messageConvert);
        int x = 0;
        // count the o's
        foreach (char o in messageConvert) { if (o == 'o') { x++; } }
        // convert it back to a string
        string reverseMessage = new String(messageConvert);
        // print it out
        Console.WriteLine(reverseMessage);
        Console.WriteLine($"'o' appears {x} times.");
    }
}
