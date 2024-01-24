using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0;

        int[] rollTotals = new int[13]; //this line is in second class

        System.Console.Write("Welcome to the dice throwing simulator!" + "\n" + "\n" + "How many dice rolls would you like to simulate? ");
        numRolls = int.Parse(Console.ReadLine());

        rollTotals = MissionTwo.RollDice.SingleRollDice(numRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS" +
            $"\nEach \"*\" represents 1% of the total number of rolls." +
            $"\nTotal number of rolls = 1000.");

        for (int total = 2; total <= 12; total++)
        {
            int percentage = rollTotals[total] * 100 / numRolls;

            Console.Write("\n" + total + ": ");
            for (int i = 0; i < percentage; i++)
            {
                Console.Write("*");
            }
        }

        Console.WriteLine ("\n\nThank you for using the dice throwing simulator. Goodbye!\r\n");

        //System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS" + "\n" + "Each '*' represents 1% of the total number of rolls." + "\n" + "Total number of rolls = 1000.");

        //System.Console.WriteLine("Thank you for using the dice throwning simulator. Goodbye!");

    }
}