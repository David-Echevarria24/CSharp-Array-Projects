namespace Arrays1;

class Program
{
    static void Main()
    {
        string[] animals = new string[3];
        animals[0] = "Cat";
        animals[1] = "Dog";
        animals[2] = "Elephant";

        animals[1] = "Dolphin";
        Console.WriteLine($"Updated second animal: {animals[1]}");


        int[] numbers = { 10, 20, 30, 40 };

        Console.WriteLine($"Length of animals array : {animals.Length}");
        Console.WriteLine($"Number of animals array : {numbers.Length}");

        Console.WriteLine(numbers[^1]);
        Console.WriteLine(numbers[^2]);

        int[] slice = numbers[1..3];
        Console.WriteLine($"Length of slice array: {slice.Length}");
        }
}
