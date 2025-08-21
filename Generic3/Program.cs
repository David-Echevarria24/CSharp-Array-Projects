using System.Collections;
using System.Globalization;
 
class Program
{
    static void Main()
    {
        Queue ngTasks = new Queue();
        ngTasks.Enqueue("Backup");
        string ngTask = (string)ngTasks.Dequeue();
        Console.WriteLine($"ngTask is {ngTask}");
 
        Queue<string> gTasks = new Queue<string>();
        gTasks.Enqueue("Backup");
        string gTask = gTasks.Dequeue();
        Console.WriteLine($"gTask is {gTask}");
 
    }
 
}
 
