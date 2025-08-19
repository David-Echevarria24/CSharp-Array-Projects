namespace Parameters5;

class Program
{
    static void Main(string[] args)
    {
        string a = "3";
        string b = "4";
        string c = "0";

        Multiply(a , b , ref c);
        Console.WriteLine($"Multiply Method: {a} x {b} = {c}");

    }
    static void Multiply(string a, string b, ref string c)
    {
        c = (int.Parse(a) * int.Parse(b)).ToString();
        Console.WriteLine($"Inside Multiply Method: {a} x {b} = {c}");
    }
}
