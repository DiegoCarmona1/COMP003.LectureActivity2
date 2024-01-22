/* 
 * Author: Diego Carmona
 * Course: COMP-003A
 * Purpose: Lecture Activity for variables, type system, Math, and Console Properties
 * reference: The C# Player's Guide (4e) by RB Whitaker
 */

using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using static System.Formats.Asn1.AsnWriter;

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

            // another example of the three primary variable related activities (declaring, assigning, and retrieving)
            string favoriteColor;
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favoriteColor);

            /* working with variable integers */
            int score; // declare a new variable with a data type int
            // score = "Generic User"; // will fail to compile because you are assigning a string value to an integer variable
            // score = "0"; // will still fail to compile because the "0" is still assigned as a string -enclosed in the double quotes
            score = 0; // works
            score = 4; // you can also reassign values to the variable as long as they are within scope and not constant\
            score = 11;
            score = -1564;

            /* reading from a variable does not change it */
            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The current value of a: " + a);
            Console.WriteLine("The current value of b: " + b);

            /* variables are case-sensitive */
            // the variables below are different despite having similar names
            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("**************************************************");
            /*
             * types of variables and values matter in C#. they are not interchangeable.
             * there are eight integer types for storing integers of differing sizes and ranges: int, short, long, byte, sbyte, uint, ushort, and ulong.
             * the char type stores single characters.
             * the string type stores longer text.
             * there are three types for storing real numbers: float, double, and decimal.
             * the bool type stores truth values (true and false) used in logic.
             * these types are the building blocks of a much larger type system.
             * using var for a variable’s type tells the compiler to infer its type from the surrounding code, so you do not have to type it out. (But it still has a specific type.)
             * the System.Convert class is a useful class to convert from one type to another.
             */

            /* declaring and using variables with integer types */
            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte: " + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte: " + aSingleByte);

            short aNumber = 5039;
            Console.WriteLine("aNumber: " + aNumber);
            aNumber = -4354;
            Console.WriteLine("aNumber: " + aNumber);

            long aVeryBigNumber = 395904282569;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
            aVeryBigNumber = 13;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);

            int anInteger = 2147483647;

            /* declaring,using, and concatenating characters and strings */
            char aLetter = 'A'; // character values are enclosed in single quotes
            string message = "Hello World!"; // string values are enclosed in double quotes

            Console.WriteLine("Concatenation using + : " + aLetter + " " + message); //use the plus(+) sign in between characters/strings to concatenate
            Console.WriteLine($"Concatenation using string interpolation : {aLetter}{message} "); // use string interpolation with a dollar-sign ($) before the opening double-quote and enclosing variables with curly braces ({variableName})

            /* floating-point types */
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"Value of number1: {number1}");
            Console.WriteLine($"Value of number2: {number2}");
            Console.WriteLine($"Value of number3: {number3}");


        }
    }
}
