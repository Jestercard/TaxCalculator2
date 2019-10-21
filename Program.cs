using System;
using System.Collections.Generic;

namespace TaxCalculator2
{
    public class Program
    {
        static void Main()
        {
            List<Bracket> brackets = new List<Bracket>
            {
                new Bracket(0, 10000, 0),
                new Bracket(10001, 30000, .1),
                new Bracket(30001, 100000, .25),
                new Bracket(100001, int.MaxValue, .4),
            };
            bool programExit = false;

            while (!programExit)
            {
                Console.WriteLine("Tax Bracket Calculator");
                Console.WriteLine("______________________");
                int counter = 0;
                foreach (var c in brackets)
                {
                    Console.WriteLine($"Bracket {counter + 1}: [{brackets[counter].Min}, {brackets[counter].Max}, {brackets[counter].Rate}]");
                    counter++;
                }

                Console.WriteLine();
                Console.WriteLine("Input your total income:");
                string input = Console.ReadLine();
                bool success = double.TryParse(input, out double income);
                if (success)
                {
                    double taxOwed = Calculation.TaxCalculation(brackets, income);
                    Console.WriteLine($"With an income of {income}, the total taxes owed is {taxOwed}.");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("Would you like to calculate another value? Y/N");
                string input2 = Console.ReadLine();
                if(input2.ToLower() == "n")
                {
                    programExit = true;
                }
                Console.Clear();
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
