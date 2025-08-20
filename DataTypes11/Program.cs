namespace DataTypes11;  //Used record, classes and struct

class Program
{
    public struct Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // public class Person
    // {
    //     public string Name { get; }
    //     public int Age { get; }

    //     public Person(string name, int age)
    //     {
    //         Name = name;
    //         Age = age;
    //     }
    // }

    // public record Person(string Name, int Age);

    static void Main()
    {
        Person person1 = new Person("Alice", 25);
        Person person2 = new Person("Alice", 25);

        // comparison using structural equality
        if (person1.Equals(person2))
        {
            Console.WriteLine("The two persons are equal");
        }
        else
        {
            Console.WriteLine("The two persons are not equal");
        }

        // comparison using structural equality
        // if (ReferenceEquals(person1, person2))
        // {
        //     Console.WriteLine("The two persons are the same object");
        // }
        // else
        // {
        //     Console.WriteLine("The two persons are different objects");
        // }
    }
}      

