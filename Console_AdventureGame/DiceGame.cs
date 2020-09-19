using System;
using System.Collections.Generic;
using System.Text;

namespace Console_AdventureGame
{
    class DiceGame
    {
        public static void DiceRoll()
        {

        Random dice = new Random();
        int randomRoll = dice.Next(0, 7);

        Console.Clear();
            Console.WriteLine("The Celebrity flies down with their personal helicopter to pick you up. \n" +
                "\n" +
                "But before you take off he says, \"Let's play a game...\"\n" +
                "\n" +
                "\"If you roll an EVEN number with this six sided die, I'll fly you directly there and hook you up with backstage passes\".\n" +
                "\"But if you roll an ODD number, I leave you here and you walk back home.\"\n" +
                "\n" +
                "\n" +
                "Press ENTER to roll the die...");
            Console.ReadLine();

            if (randomRoll == 2 || randomRoll == 4 || randomRoll == 6)
            {
                Console.Clear();
                Console.WriteLine("You rolled a" + " " + randomRoll + "\n" +
                    "\n" +
                    "Congrats!  You jump in the helicopter and have the time of your life at Coachella.\n" +
                    "\n");

                Program.PlayAgain();

            }
            else if (randomRoll == 1 || randomRoll == 3 || randomRoll == 5)
            {
                Console.Clear();
                Console.WriteLine("You rolled a" + " " + randomRoll + "\n" +
                    "\n" +
                    "RATS! The Celebrity puts on his shades and jump back in the helicopter.\n" +
                    "You walk home kicking rocks and listening to all the Coachella artists on your iPhone.");

                Program.PlayAgain();

            }
        }
    }
}
