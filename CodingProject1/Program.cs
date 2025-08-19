namespace CodingProject1;

using System;

class Program
{
    static void Main()
    {
      
    
                // Create a 2D array to store grades for 4 students, each with 5 test scores
                int[,] gradeStorage = new int[4, 5]
                {
            { 90, 86, 87, 98, 100 },  // Sophia's test scores
            { 92, 89, 81, 96, 90 },   // Andrew's test scores
            { 90, 85, 87, 98, 68 },   // Emma's test scores
            { 90, 85, 87, 88, 96 }    // Logan's test scores
                };

                // Array to store the total points for each student (using decimal for precise averages)
                decimal[] gradeTotal = new decimal[gradeStorage.GetLength(0)];

                // Array containing student names in the same order as their grades
                string[] studentName = { "Sophia", "Andrew", "Emma", "Logan" };

                // STEP 1: Calculate total points for each student
                // Outer loop goes through each student (row)
                for (int row = 0; row < gradeStorage.GetLength(0); row++)
                {
                    // Inner loop goes through each test score for the current student (column)
                    for (int col = 0; col < gradeStorage.GetLength(1); col++)
                    {
                        // Add each test score to the student's running total
                        gradeTotal[row] += gradeStorage[row, col];
                    }
                }

                // STEP 2: Calculate averages and display results with letter grades
                for (int row = 0; row < studentName.Length; row++)
                {
                    // Calculate average by dividing total points by number of tests (5)
                    decimal average = gradeTotal[row] / gradeStorage.GetLength(1);

                    // Convert the numerical average to a letter grade using our custom method
                    string letterGrade = ConvertToLetterGrade(average);

                    // Display student name, average (rounded to 2 decimal places), and letter grade
                    Console.WriteLine($"{studentName[row]}: {average:F2} {letterGrade}");
                }
            }



            // Custom method that converts a numerical grade to a letter grade
            // Takes a decimal score and returns the corresponding letter grade as a string
            static string ConvertToLetterGrade(decimal score)
            {
                // Use if-else chain to determine letter grade based on standard grading scale
                if (score >= 97) return "A+";      // 97-100%
                else if (score >= 93) return "A";  // 93-96%
                else if (score >= 90) return "A-"; // 90-92%
                else if (score >= 87) return "B+"; // 87-89%
                else if (score >= 83) return "B";  // 83-86%
                else if (score >= 80) return "B-"; // 80-82%
                else if (score >= 77) return "C+"; // 77-79%
                else if (score >= 73) return "C";  // 73-76%
                else if (score >= 70) return "C-"; // 70-72%
                else if (score >= 67) return "D+"; // 67-69%
                else if (score >= 63) return "D";  // 63-66%
                else if (score >= 60) return "D-"; // 60-62%
                else return "F";                   // Below 60% = Failing
            }
        }
    
