using System.Collections;
using System.Diagnostics;
using System.Globalization;
 
class Program
{
    static void Main()
    {
        Stack ngActions = new Stack();
        ngActions.Push("Action1");
        string ngAction = (string)ngActions.Pop();
        Console.WriteLine($"ngAction is {ngAction}");
 
        Stack<string> gActions = new Stack<string>();
        gActions.Push("Action1");
        string gAction = gActions.Pop();
        Console.WriteLine($"gAction is {gAction}");
 
    }
 
}
