using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MissionTwo
{
    internal class RollDice
    {
        private static Random random = new Random();

        public static int[] SingleRollDice(int numRolls)
        {
            int[] rollTotals = new int[13];

            for (int i = 1; i <= numRolls; i++)//for the number of times that the user specified
            {
                int die1 = random.Next(1, 7); //random number 1-6
                int die2 = random.Next(1, 7); //random number 1-6
                int total = die1 + die2;


                rollTotals[total]++;
            }
            return rollTotals;
            //Rolls are done

        }
    }
}
