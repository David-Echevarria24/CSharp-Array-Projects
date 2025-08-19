namespace DataTypes5;

class Program
{
    static void Main(string[] args)
    {
        // int wholeNumber = 7;
        // double result = wholeNumber;
        // int age = 30;
        // string ageString = age.ToString();

        // Console.WriteLine(ageString);
        // string input = "123";
        // int parsedValue = int.Parse(input);
        // Console.WriteLine(parsedValue);

        string input = "123";
        int number;

        bool success = int.TryParse(input, out number);
        if (success)
        {
            Console.WriteLine($"Conversion succeeded{number}");
        }

    }
}
