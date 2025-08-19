namespace ConsoleApp9;

class Program
{
    static void Main(string[] args)
    {

       
        // int a = int.MaxValue;
        // System.Console.WriteLine(a);
        // a++;
        // System.Console.WriteLine(a);
        // long b = 10;
        // var result1 = a + b;
        // System.Console.WriteLine(result1);
        // System.Console.WriteLine(result1.GetType());


       
       
        // int c = 100;
        // double d = 3.14;
        // var result2 = c + d;
        // System.Console.WriteLine(result2);
        // System.Console.WriteLine(result2.GetType());
       
       
       
       
        //byte b1 = 200;
        // byte b2 = 50;
        // byte result3 = (byte)(b1 + b2);
        // System.Console.WriteLine(result3);
        // System.Console.WriteLine(result3.GetType());


        // Write code to determine the remainder after integer division
        // int totalMinutes = 135;
        // int minutesPerHour = 60;
        // int leftoverMinutes = totalMinutes % minutesPerHour;
        // System.Console.WriteLine(leftoverMinutes);
        
        
        // Use System.Math.Pow() method to apply exponents
        // double baseNum = 3;
        // double exponent = 4;
        // double power = System.Math.Pow(baseNum, exponent);
        // System.Console.WriteLine(power);

        // Write code to increment and decrement a value
        // Use the increment operator before and after the value
        // int a = 5;
        // int b = ++a;
        // int b = a++;
        // System.Console.WriteLine(a);
        // System.Console.WriteLine(b);

        // int items = 3;
        // System.Console.WriteLine(items--);
        // System.Console.WriteLine(items);   // Should display 3, 2

        int fahrenheit = 150;
        decimal celsius = (fahrenheit - 32m) * (5m / 9m);
        Console.WriteLine("The temperature is " + celsius + "\u00B0C.");


    }
}
