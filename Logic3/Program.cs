namespace Logic3;

class Program
{
    static void Main(string[] args)
    {
        // int score = 85;
        // single Console.WriteLine statement
        //check the value of the score
        // display A, B, or C, depending on the value of score
        //  Console.WriteLine($"Grade: {(score >= 90 ? "A" : score > 80 ? "B" : "C")}");

        Random coin = new Random();
        int coinflip = coin.Next(1, 3);
        Console.WriteLine(coinflip == 1 ? "Heads" : "Tails");

    }
}
