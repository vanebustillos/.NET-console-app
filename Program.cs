using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime parsedDate;

            while (true)
            { 
                // Prompt the user to enter a date in MM/dd/yyyy format
                Console.Write("Enter a date (MM/dd/yyyy): ");
                string inputDate = Console.ReadLine();

                // Parse the input date and store it in the DateTime parsedDate variable.
                if (DateTime.TryParse(inputDate, out parsedDate))
                {
                    Console.WriteLine("Valid date!");
                    break; // Exit the loop if the date is valid
                }
                else
                {
                    Console.WriteLine("Invalid date. Please re-enter in the format MM/dd/yyyy.");
                }
            }

            // Ask the user if they want to add days to the date
            Console.Write("Do you want to add a number of days to this date? (y/n): ");
            string inputChoice = Console.ReadLine().ToLower();

            if (inputChoice == "y")
            {
                // Prompt for the number of days that the user wants to add
                Console.Write("Please, enter the number of days to add: ");
                if (int.TryParse(Console.ReadLine(), out int daysToAdd))
                {
                    // Add the specified number of days to the parsed date
                    DateTime newDate = parsedDate.AddDays(daysToAdd);
                    Console.WriteLine("The new date is: {0:MM/dd/yyyy}", newDate);
                }
                else
                {
                    Console.WriteLine("Invalid number of days.");
                }
            }
            else
            {
                // Add 10 days by default if the user types anything else
                DateTime newDate = parsedDate.AddDays(10);
                Console.WriteLine("Adding 10 days as a default. The new date is: {0:MM/dd/yyyy}", newDate);
            }
            

            // Pause the console to keep it open
            Console.ReadKey();
        }
    }
}
