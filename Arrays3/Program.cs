namespace Arrays3;

class Program
{
    static void Main()  //Display numbers in array reversed
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

         for (int i = numbers.Length - 1; 1 >= 0; i--) //Used with for loop
         {
         Console.WriteLine(numbers[i]);
         }

        //Foreach Loop
        // foreach (int number in numbers.Reverse())
        // {
            // Console.WriteLine(number);


        // }



    }

}
