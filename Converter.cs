using System;

namespace Convert_CepilloCharlotte
{
    internal class Converter
    {
        public void Run()
        {
            Console.WriteLine("Welcome to CJ's Converter please choose ONE number only!");
            Console.WriteLine("........................................................");
            Console.WriteLine("1. Seconds to Minutes");
            Console.WriteLine("2. Minutes to Hours");
            Console.WriteLine("3. Hours to Days");
            Console.WriteLine("4. Days to Months");
            Console.WriteLine("........................................................");

            Console.Write("Enter your choice (1 - 4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ConvertSecondsToMinutes();
                    break;
                case 2:
                    ConvertMinutesToHours();
                    break;
                case 3:
                    ConvertHoursToDays();
                    break;
                case 4:
                    ConvertDaysToMonths();
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please enter a number 1 to 4 only.");
                    break;
            }
        }

        private void ConvertSecondsToMinutes()
        {
            Console.Write("Enter the number of Seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            double minutes = seconds / 60.0;
            Console.WriteLine($"{seconds} seconds is equal to {minutes} minutes.");
        }

        private void ConvertMinutesToHours()
        {
            Console.Write("Enter the number of Minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            double hours = minutes / 60.0;
            Console.WriteLine($"{minutes} minutes is equal to {hours} hours.");
        }

        private void ConvertHoursToDays()
        {
            Console.Write("Enter the number of Hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            double days = hours / 24.0;
            Console.WriteLine($"{hours} hours is equal to {days} days.");
        }

        private void ConvertDaysToMonths()
        {
            Console.Write("Enter the number of Days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            double months = days / 30.0; // Appromixation, assuming 30 days per month
            Console.WriteLine($"{days} days is equal to {months} months.");
        }
    }
}