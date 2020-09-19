using System;
using System.Security.Cryptography.X509Certificates;

namespace Console_AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu.Menu();
        }
        
        public static void PlayAgain()
        {

            Console.WriteLine("\n" +
                "Do you want to play again? (Yes or No?)");
            string playAgainResponse = Console.ReadLine().ToLower();
            if (playAgainResponse == "yes" || playAgainResponse == "y")
            {
                MainMenu.Menu();
            }
            else if (playAgainResponse == "no" || playAgainResponse == "n")
            {
                Console.WriteLine("Thanks for playing");
            }
            else
            {
                Console.WriteLine("I don't understand that command.  Please enter \"Yes\" or \"No\"");
                PlayAgain();
            }
        }
    }
}