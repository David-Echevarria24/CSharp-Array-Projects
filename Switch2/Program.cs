namespace Switch2;

class Program
{
    static void Main(string[] args)
    {
        int studentGradeLevel = 2;
        string studentName = "David";
        string gradeDescription;

        switch (studentGradeLevel)
        {
            case 1:
                // gradeDescription = "Freshman";
                // break;
            case 2:
                gradeDescription = "Lower Division";
                // gradeDescription = "Sophomore";
                break;
            case 3:
                gradeDescription = "Junior";
                break;
            case 4:
                gradeDescription = "Senior";
                break;
            default:
                gradeDescription = "Unspecified Level";
                break;
        }
        Console.WriteLine($"{studentName}:\t{gradeDescription}");

    }
}
