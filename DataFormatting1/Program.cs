namespace DataFormatting1;

class Program
{
    static void Main()
    {
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");
 
    }
 
}