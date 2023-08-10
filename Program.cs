using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fødselsdagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking user for desired input
            Console.Write("Enter your birthday (In this format 13042001, day,month,year): \n");
            // Creating a string variable with the input
            string readin = Console.ReadLine();
            // Here we parse our input in as a DateTime datatype.
            DateTime birthday = DateTime.ParseExact(readin, "ddMMyyyy", null);
            // Getting time now
            DateTime now = DateTime.Now;
            // Calculating how much time has passed between the birthday and now.
            TimeSpan difference = now - birthday;
            // Calculating how many years has passed.
            int years = (int)Math.Floor(difference.TotalDays / 365.2425);
            // Adding the years to the birth date.
            birthday = birthday.AddYears(years);
            // Subtracting birthday from now to get days. 
            difference = now - birthday;
            // Flooring days to get precise amount of days instead of getting a number like 122,22 days.
            int days = (int)Math.Floor(difference.TotalDays);
            // Writing results.
            Console.WriteLine("You are " + years + " years old and " + days + " days old.");
            Console.ReadLine();
        }
    }
}
