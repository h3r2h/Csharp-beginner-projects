using System;

namespace Subroutines_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------------
            // STEP 1: Program Execution Starts Here
            // ---------------------------------------------------------
            // We call our first custom subroutine (GetValidMark) to ask the user 
            // for a mark. The text inside the quotes is passed as a "parameter".
            int studentMark = GetValidMark("Enter mark for Student 1 (0-100):");

            // We call our second custom subroutine (CalculateGrade), passing 
            // the validated studentMark into it, and store the returned string result.
            string studentGrade = CalculateGrade(studentMark);

            // ---------------------------------------------------------
            // STEP 2: Display Final Results
            // ---------------------------------------------------------
            Console.WriteLine("\n--- Student Result ---");
            Console.WriteLine($"Validated Mark: {studentMark}/100");
            Console.WriteLine($"Calculated Grade: {studentGrade}");

            // Pause the console window so the user can see the output before it closes
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // =========================================================
        // SUBROUTINE 1: GetValidMark
        // Purpose: Safely prompts the user, handles bad inputs without 
        // crashing, and ensures the number is between 0 and 100.
        // Returns: An integer (`int`) representing the valid mark.
        // =========================================================
        static int GetValidMark(string prompt)
        {
            int mark = 0;
            bool isValid = false; // Flag to keep our loop running until valid input is received

            // Keep looping until the user provides a valid integer BETWEEN 0 and 100
            while (!isValid)
            {
                // Display the prompt passed from Main()
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();

                // int.TryParse checks two things safely:
                // 1. Can the text be converted into a number? (stored in out mark)
                // 2. Is that number between 0 and 100 inclusive?
                if (int.TryParse(userInput, out mark) && mark >= 0 && mark <= 100)
                {
                    isValid = true; // Input is good! This will break the while loop.
                }
                else
                {
                    // If they typed letters, symbols, or out-of-range numbers, catch it here cleanly
                    Console.WriteLine("❌ Invalid input! Must be a whole number between 0 and 100.\n");
                }
            }

            // Send the final validated mark back to Main()
            return mark;
        }

        // =========================================================
        // SUBROUTINE 2: CalculateGrade
        // Purpose: Evaluates a numeric mark against standard grade 
        // boundaries to determine the letter grade.
        // Returns: A string (`string`) representing the grade (e.g., "A*", "B").
        // =========================================================
        static string CalculateGrade(int marks)
        {
            string grade;

            // Check boundaries sequentially from highest to lowest
            if (marks >= 80)
            {
                grade = "A*";
            }
            else if (marks >= 70)
            {
                grade = "A";
            }
            else if (marks >= 60)
            {
                grade = "B";
            }
            else if (marks >= 50)
            {
                grade = "C";
            }
            else
            {
                grade = "U"; // Fail boundary
            }

            // Send the calculated grade back to Main()
            return grade;
        }
    }
}
