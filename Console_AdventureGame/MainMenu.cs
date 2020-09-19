using System;
using System.Collections.Generic;
using System.Text;

namespace Console_AdventureGame
{
    class MainMenu
    {
        public static void Menu()
        {
            string choice;
            Console.Clear();
            Console.WriteLine("Welcome to your Millennial Adventure! \n" +
                "\n" +
                "You have just gotten a group text from your friends asking if you want to go to Coachella, but you have to leave now!\n" +
                "\n" +
                "Do you go? (Yes or No)");
            choice = Console.ReadLine().ToLower();
            if (choice == "yes")
            {
                Options.StartingPoint();
            }
            else if (choice == "no")
            {
                Console.WriteLine("Lame.  Have fun sitting at home in your parent's basement");
                Program.PlayAgain();
            }
            else
            {
                Console.WriteLine("\n" +
                    "I don't understand that command.  Please pick Yes or No.");
                Console.WriteLine("Please Enter to try again");
                Console.ReadLine();

                MainMenu.Menu();
            }
        }
    }
}
