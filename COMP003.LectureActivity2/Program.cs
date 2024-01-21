/* 
 * Author: Diego Carmona
 * Course: COMP-003A
 * Purpose: Lecture Activity for variables, type system, Math, and Console Properties
 * reference: The C# Player's Guide (4e) by RB Whitaker
 */

namespace COMP003.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Working with Variables */
            // the following code shows all three primary variable-related activities:
            string username; //declaring a variable (1 of 3)
            Console.WriteLine("What is your name?"); // request for user input
            username = Console.ReadLine(); // Assigning a value to a variable (2 of 3)
            Console.WriteLine("Hi" +  username); // retrieving its current Value (3 of 3)

            
        }
    }
}
