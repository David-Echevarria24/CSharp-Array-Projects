namespace Methods2;
class Program
{
    static Random random = new Random();
    static int luck;
    static string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
    static string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
    static string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
    static string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };
    
    static void Main()
    {
        luck = random.Next(1, 4);
        TellFortune();
    }

    static void TellFortune()
    {
        Console.WriteLine("A fortune teller whispers the following words:");
        string[] fortune = (luck == 1 ? good : luck == 3 ? bad : neutral);
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{text[i]} {fortune[i]} ");
        }
        Console.WriteLine();
    }
 
}
 
// output A: A fortune teller whispers the following words:
// You have much to look forward to.Today is a day to try new things! Whatever work you do is likely to succeed.This is an ideal time to accomplish your dreams!