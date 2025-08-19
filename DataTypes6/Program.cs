using System.Text;

namespace DataTypes6;

class Program
{
    static void Main(string[] args)
    {    string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        string message = "";
        decimal total = 0;
        decimal curr;
        foreach (string value in values)
        {
            if (decimal.TryParse(value, out curr))
            {
                total += curr;
            }
            else
            {
                message += value;
            }
        }
        Console.WriteLine($"Message: {message}\nTotal: {total}");
        // string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        // decimal number;
        // decimal total = 0;
        // StringBuilder message = new StringBuilder();
        // foreach (string value in values)
        // {
        //     if (decimal.TryParse(value, out number))
        //     {
        //         total += number;
        //     }
        //     else
        //     {
        //         message.Append(value);
        //     }
        // }
        // Console.WriteLine($"Message : {message} \nTotal: {total}");
    }
}






// output display
// Message : ABCDEF
// Total : 68.3