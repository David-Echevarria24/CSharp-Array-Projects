using System.Collections;
using System.ComponentModel;

namespace SystemCollectionsArrays;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("apple");
        list.Add("banana");
        list.Add(123);
        list.Add(true);
 
        Console.WriteLine("Access by index:");
        Console.WriteLine("First item: " + list[0]);
        Console.WriteLine("Second item: " + list[1]);
 
        list[1] = "orange";
        list.Remove("apple");
        list.Insert(1, "grape");
 
        Console.WriteLine("\nCurrent ArrayList contents:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"Index {i}: {list[i]}");
        }
 
        list.RemoveAt(1);
 
        Console.WriteLine("\nAfter RemoveAt(1):");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"Index {i}: {list[i]}");
        }
 
    }
 
}
