namespace DataFormatting3;

class Program
{
    static void Main(string[] args)
    {
        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        // your logic here
        Console.WriteLine($"Dear {customerName},");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial\nproduct that would dramatically increase your return.\n");
        Console.WriteLine($"Currently, you own {currentShares:F2} shares at a return of {currentReturn:P2}\n");
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your\npotential profit would be {newProfit:C2}\n");
        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = $"{currentProduct}\t\t{currentReturn:P2}\t{currentProfit:C2}\n" +
                                    $"{newProduct}\t\t{newReturn:P2}\t{newProfit:C2}";

        //Your logic here

        Console.WriteLine(comparisonMessage);
    }
}
