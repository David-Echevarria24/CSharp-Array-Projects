using System.Collections;
class Program
{
    static void Main()
    {
        Queue customerQueue = new Queue();
 
        customerQueue.Enqueue("Alice");
        customerQueue.Enqueue("Bob");
        customerQueue.Enqueue("Charlie");
 
        Console.WriteLine("Current queue:");
        foreach (var customer in customerQueue)
        {
            Console.WriteLine(customer);
        }
 
        Console.WriteLine($"\nNext in line: {customerQueue.Peek()}");
 
        string servedCustomer = (string)customerQueue.Dequeue();
        Console.WriteLine($"\nServed customer is {servedCustomer}");
 
        Console.WriteLine("Queue after serving one customer:");
        foreach (var customer in customerQueue)
        {
            Console.WriteLine(customer);
        }
 
    }
 
}
 