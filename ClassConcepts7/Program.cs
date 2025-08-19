using System.Text;

namespace ClassConcepts7;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder  sb = new StringBuilder();
        Foo(sb);
        Console.WriteLine(sb.ToString());
    }
 
    static void Foo(StringBuilder fooSB)
    {
        fooSB.Append("test");
        fooSB = null;
    }
}
