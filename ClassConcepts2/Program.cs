namespace ClassConcepts2;

class Program
{
    static void Main()
    {
        Panda frank = new Panda("Frank", 4);
        Panda wendy = new Panda("Wendy", 7);
        frank.CelebrateBirthday();
 
 
    }
}
 
class Panda
{
    string name;
    int age;
    static int totalPandas = 0;
 
    public Panda(string name, int age)
    {
        this.name = name;
        this.age = age;
        totalPandas++;
    }
 
    //Stateful, Non-static
    public void CelebrateBirthday()
    {
        age++;
        Console.WriteLine($"{name} is now {age} years old");
    }
 
    //Stateful, Static
    public static int GetTotalPandas()
    {
        return totalPandas;
    }
 
    //Stateless, Static
    public static bool ViewingDays(DayOfWeek day)
    {
        return day >= DayOfWeek.Monday && day <= DayOfWeek.Friday;
    }
 
}