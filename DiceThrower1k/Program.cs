using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1k
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling my ThrowDice function
            ThrowDice("10d6");

            ThrowDice("3d20");

            ThrowDice("100d6");


            //keep the console open
            Console.ReadKey();
        }
        //creating the ThrowDice function
        static void ThrowDice(string diceString)
        {
            //splitting diceString at the 'd'
            string[] temp = diceString.Split('d');
            //giving diceRolls the value of the first index after the split
            string diceRolls = temp[0];
            //giving diceSides the value of the next index after the split
            string diceSides = temp[1];
            //converting diceRolls to an int
            int diceRollTot = int.Parse(diceRolls);
            //converting diceSides to an int
            int diceSideTot = int.Parse(diceSides);
            //generating a random number
            Random randomNumGen = new Random();
            //for the number of rolls
            //setting the random number
            int randomNum = randomNumGen.Next(1, diceSideTot + 1);

            //printing to the console
            Console.WriteLine("Throwing: " + diceString);
            Console.Write("Result #: " );
           

            for (int i = 1; i <= diceRollTot; i++)
            {
                Console.Write(randomNumGen.Next(1, diceSideTot + 1) + " ");
            }

            Console.WriteLine();
            
        }
    }
}
