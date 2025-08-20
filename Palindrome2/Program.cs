namespace Palindrome2;

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "civic", "deed", "noon" };
        int palindromeCount = 0;
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (IsPalindrome(word))
            {
                Console.WriteLine(word);
                palindromeCount++;
            }
            
        }
        
        Console.WriteLine($"Total of palindromes: {palindromeCount}");
        
    }
    static bool IsPalindrome(string word)
    {
        int start = 0;
        int end = word.Length - 1;
        while (start < end)
        {
            if (word[start] != word[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }

}
// civic  
// deed  
// noon  
// Total palindromes found: 3