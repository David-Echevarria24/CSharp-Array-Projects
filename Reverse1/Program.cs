namespace Reverse1;

class Program
{
    static void Main(string[] args)
    {
        string pangram = "The quick brown fox jumps over the lazy dog";
 
        string[] words = pangram.Split(" ");
 
        string[] newWords = new string[words.Length];
 
        for (int i = 0; i < words.Length; i++)
        {
            char[] letters = words[i].ToCharArray();
            Array.Reverse(letters);
            newWords[i] = new string(letters);
        }
        string result = String.Join(" ", newWords);
        Console.WriteLine(result);
    }
}