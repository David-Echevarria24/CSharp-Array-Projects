using System.Text;

namespace Practice;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("hello, world");
        // for (int i = 0; i < 50; i++)
        // {
        //     sb.Append(i).Append(",");
        // }
        sb.Replace("world", "C#");
        sb.Remove(5,1);

        sb.ToString(); // to use string methods

        Console.WriteLine(sb);
 
    }
 
}
 