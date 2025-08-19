namespace Logic2;

class Program
{
    static void Main(string[] args)
    {
        //Write code that uses the equality operator
        // int score = 90;
        // bool notPerfect = (score != 100);
        // Console.WriteLine($"{notPerfect}");
        // Improve the check for string equality using the string's built-in helper methods
        // Write code that uses the inequality operator
        // Write code that uses the comparison operators
        // Write code that uses a method invocation expression
        // Write code that uses the logical negation operator

        // int temp = 90;
        // bool isHot = (temp > 85);
        // Console.WriteLine(isHot);

        // string name = "gregor";
        // string upperName = name.ToUpper();

        // Console.WriteLine($"{upperName}");

        // bool isLoggedIn = false;
        // if (!isLoggedIn)
        // {
        //     Console.WriteLine("you need to log in first");
        // }

        // int a = 5;
        // int b = 10;
        // Console.WriteLine(a == b);
        // Console.WriteLine(a != b);

        // Person p1 = new Person("Lara");
        // Person p2 = new Person("Lara");
        // Person p3 = p1;
        
        string s1 ="hello";
        string s2 = "hello";
        string s3 = new string("hello".ToCharArray());

        
        Console.WriteLine(s1 == s2);
        Console.WriteLine(s1 == s3);
    }
}

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    


}