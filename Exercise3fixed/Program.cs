using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3fixed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Messed up first repository this is fixed version


            // Display Interest calculator program on screen
            Console.WriteLine("Interest Calculator Program");
            // Ask user for loan amount in dollars
            Console.WriteLine("What is the principal amount of the loan in dollars?");
            // convert user input to integer
            int principal = Convert.ToInt32(Console.ReadLine());
            // Ask user for interest rate
            Console.WriteLine("What is interest rate (input 0.05 for 5%)?");
            // convert user input to a double
            double rate = Convert.ToDouble(Console.ReadLine());
            // Ask user for the period of the loan
            Console.WriteLine("What is period of loan in years?");
            // Convert user input to integer
            int period = Convert.ToInt32(Console.ReadLine());
            // Calculate total by multiplying our variables
            double total = (principal * rate * period);
            // Print out total on screen in a full sentence
            Console.WriteLine("Total interest of Loan:" + total + " dollars.");
            // Pause screen for user
            Console.ReadLine();
        }
    }
}
