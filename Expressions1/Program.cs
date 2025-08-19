using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Expressions1;

class Program
{
    static void Main(string[] args)
    {
        // var square = (int x) => x * x;

        // int number = 5;
        // int result = square(number);
        // Console.WriteLine($"Square of {number} is {result}");

        var multiply = (int x, int y) =>
        {
            int product = x * y;
            Console.WriteLine($"Multiplying {x} and {y} gives {product}");
            return product;
        };
        int result = multiply(4, 5);
        
    }
}
