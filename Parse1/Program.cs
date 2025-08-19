namespace Parse1;

class Program;
// Pseudocode:
// 1. Define the input string containing order IDs separated by commas.
// 2. Set the expected length for a valid order ID.
// 3. Split the input string into an array using the comma as a separator.
// 4. Sort the array of order IDs alphabetically.
// 5. For each order ID in the sorted array:
//    a. If the order ID does not have the expected length, print it with an error message.
//    b. Otherwise, print the order ID as valid.
 
 
class ParseStringSortOrders_Exercise
{
  static void Main(string[] args)
  {
    // 1. Define the input string containing order IDs separated by commas.
    string orderIDs = "A234,Z54678,D23456,T902,S4221,K5456,P4356";
 
    // 2. Set the expected length for a valid order ID.
 
 
    // 3. Split the input string into an array using the comma as a separator.
    string[] individualOrderNumbers = orderIDs.Split(",");
 
    // 4. Sort the array of order IDs alphabetically.
    Array.Sort(individualOrderNumbers);
 
    // 4.1 Declare variables
    int correctOrderIndex = 0;
    int incorrectOrderIndex = 0;
    // Review this step!
    string[] errorOrder = new string[individualOrderNumbers.Length];
    string[] correctOrder = new string[individualOrderNumbers.Length];
 
 
    // 5. For each order ID in the sorted array:
 
    foreach (string individualOrderNumber in individualOrderNumbers)
    {
      //    a. If the order ID does not have the expected length, print it with an error message.
      if (individualOrderNumber.Length != 5)
      {
        errorOrder[incorrectOrderIndex++] = individualOrderNumber;
      }
      //    b. Otherwise, print the order ID as valid.
      else
      {
        correctOrder[correctOrderIndex++] = individualOrderNumber;
      }
    }
    // 5.1 Above we read arrays [int!!!!!!!]. Below we need go through each individualOrderNumber.
    for (int i = 0; i < incorrectOrderIndex; i++)
    // 6. Segregate the Error and Correct Indexes into Arrays
    // 7. Print the Error Indexes
    {
      System.Console.WriteLine($" {errorOrder[i]} - Error Order");
    }
    // 8. Print the Correct Indexes
    for (int i = 0; i < correctOrderIndex; i++)
    {
      System.Console.WriteLine(correctOrder[i]);
    }
  }
}
 