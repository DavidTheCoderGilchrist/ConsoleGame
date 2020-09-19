using System;
using System.Collections.Generic;
using System.Text;

namespace _0_ChickenScratch3
{
    public class DiceGame2
    {
        public static void DiceRoll()
        {
            Random dice = new Random();
            int randomRoll = dice.Next(1, 6);

            Console.Clear();
            Console.WriteLine("The Celebrity flies down with their personal helicopter to pick you up, but before you take off he/she says, \n" +
                "\"Let's play a game...If you roll an even number with this six sided die, I'll fly you directly there and hook you up with backstage passes\". " +
                "If you roll an odd number, I leave you here and you walk back home.\n" +
                "\n" +
                "\n" +
                "Press ENTER to roll the die...");
            Console.ReadLine();

            if (randomRoll == 2 || randomRoll == 4 || randomRoll == 6)
            {
                Console.Clear();
                Console.WriteLine("You rolled a" + " " + randomRoll + "\n" +
                    "\n" +
                    "Congrats!  You jump in the helicopter and have the time of your life at Coachella\n" +
                    "\n");

            }
            else if (randomRoll == 1 || randomRoll == 3 || randomRoll == 5)
            {
                Console.Clear();
                Console.WriteLine("You rolled a" + randomRoll + "! \n" +
                    "\n" +
                    "RATS! The Celebrity puts on his/her shades and jump back in the helicopter.\n" +
                    "You walk home kicking rocks and listening to your favority bands on your iPhone\n" +
                    "\n");

            }
        }
    }
    
}
