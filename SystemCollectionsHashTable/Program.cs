using System.Collections;
class Program
{
    static void Main()
    {
        Hashtable table = new Hashtable();
 
        table["age"] = 30;
        table["price"] = 19.99;
        table["status"] = true;
 
        int age = (int)table["age"];
        double price = (double)table["price"];
        bool status = (bool)table["status"];
 
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Status: {status}");
 
        //long wrongType = (long)table["age"];
        long safeType = (int)table["age"];
        Console.WriteLine($"\nSafe conversion to long {safeType}");
    }
 
}