using System.Runtime.ExceptionServices;

namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        bool FirstCondition()
        {
            Console.WriteLine("First condition evaluated");
            return false;

        }

        bool SecondCondition()
        {
            Console.WriteLine("Second condition evaluated");
            return true;
        }

        if (FirstCondition() && SecondCondition())
        {
            Console.WriteLine("Both conditions are true");
        }

        else
        {
            Console.WriteLine("At least one condition is false");
        }
        
    }
}
