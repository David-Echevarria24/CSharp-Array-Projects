namespace DiceRandom;

class Program
{
    static void Main()
    {
        Random dice = new Random();
        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);
        int rollTotal = roll1 + roll2 + roll3;
        if (rollTotal >= 15)
        {
            Console.WriteLine("New High Score!");
        }
        else if (rollTotal < 6)
        {
            Console.WriteLine("Low score");
        }

        if (roll1 == roll2 && roll2 == roll3)
        {
            rollTotal += 6;
            Console.WriteLine("Super Bonus!");
        }
        else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
        {
            rollTotal += 2;
            Console.WriteLine("Bonus!");
        }

        Console.WriteLine($"You rolled {rollTotal}!");
        
    }   


}


