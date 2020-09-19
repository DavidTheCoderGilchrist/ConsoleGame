using System;
using System.Collections.Generic;
using System.Text;

namespace Console_AdventureGame
{
    class Options
    {
        
            public static void StartingPoint()
            {
                string startingPointResponse;
                Console.Clear();
                Console.WriteLine("Great! How are you going to get to your friend's house?\n" +
                    "1. Scooter \n" +
                    "2. Uber");
                startingPointResponse = Console.ReadLine().ToLower();
                if (startingPointResponse == "scooter" || startingPointResponse == "1")
                {
                    OptionOne();
                }
                else if (startingPointResponse == "uber" || startingPointResponse == "2")
                {
                    OptionTwo();
                }
                else
                {
                    Console.WriteLine("\n" +
                        "I don't understand that command.  Please pick option \"1\" or \"2\"");
                    Console.WriteLine("Press Enter to try again");
                    Console.ReadLine();
                    StartingPoint();
                }
            }
            public static void OptionOne()
            {
                Console.Clear();
                Console.WriteLine("A Lime scooter, huh? So trendy! \n" +
                    "Are you going to wear a helmet?\n" + 
                    "1. Yes \n" +
                    "2. No");
                string optionOneResponse = Console.ReadLine().ToLower();
                if (optionOneResponse == "yes" || optionOneResponse == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Your friends see you showing up in a super lame helmet and un-invite you to the festival. \n" +
                    "You head back home :( ");
                    Program.PlayAgain();
                }
                else if (optionOneResponse == "no" || optionOneResponse == "2")
                {
                    OptionThree();
                }
                else
                {
                    Console.WriteLine("\n" +
                        "I don't understand that command.  Please enter \"Yes\" or \"No\"");
                    Console.WriteLine("Press Enter to try again");
                    Console.ReadLine();
                    OptionOne();
                }
            }
            
            public static void OptionTwo()
            {
                Console.Clear();
                Console.WriteLine("Your Uber arrives and you yell \"Hurry I need to get to my friends house right away!\" \n" +
                    "As your Uber speeds recklessly down the street the Uber hits a pot hole and gets a flat tire. \n" +
                    "\n" +
                    "What do you do?  \n" +
                    "1. Walk back home.\n" +
                    "2. Go live on Instgram and plead for somone to pick you up.");

                string optionTwoResponse = Console.ReadLine().ToLower();

                if (optionTwoResponse == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Well there is always next year...\n" +
                        "\n");

                    Program.PlayAgain();
                }
                else if (optionTwoResponse == "2")
                {
                    OptionFour();
                }
                else
                {
                    Console.WriteLine("\n" +
                        "I don't understand that command.  Please pick option \"1\" or \"2\"");
                    Console.WriteLine("Press Enter to try again");
                    Console.ReadLine();
                    OptionTwo();
                }
            }
            public static void OptionThree()
            {
                Console.Clear();
                Console.WriteLine("You arrive at your friend's house in style. They're ready to leave. Who do you ride with?\n" + 
                    "1. Your Crush \n" +
                    "2. Your Friends");
                string optionThreeResponse = Console.ReadLine().ToLower();
                if (optionThreeResponse == "crush" || optionThreeResponse == "your crush" || optionThreeResponse == "1")
                {
                    Console.Clear();
                    Console.WriteLine("As you travel through Vegas, you and your crush overcome your Millenial fear of committment, get married, eat avocado toast, and buy souvenirs for your dogs ");
                    Program.PlayAgain();
            }
            else if (optionThreeResponse == "friends" || optionThreeResponse == "your friends" || optionThreeResponse == "2")
                {
                    OptionFive();
                }
                else
                {
                    Console.WriteLine("\n" +
                        "I don't understand that command.  Please pick option \"1\" or \"2\"");
                    Console.WriteLine("Press Enter to try again");
                    Console.ReadLine();
                    OptionThree();
                }
            }
            
            public static void OptionFour()
            {
                Console.Clear();
                Console.WriteLine("You go live and two people respond!  One is your best friend and the other is a TikTok celebrity. \n" +
                    "\n" +
                    "Which one do you respond to?\n" +
                    "1. Friend \n" +
                    "2. TikTok Celebrity");
                string optionFourResponse = Console.ReadLine().ToLower();

                if (optionFourResponse == "1" || optionFourResponse == "friend")
                {
                    Console.Clear();
                    Console.WriteLine("Your friend comes to pick you up and is ready to drive you all the way to California!");
                    Console.WriteLine("Press Enter to hop in the car");
                    Console.ReadLine();

                    OptionFive();
                }
                else if (optionFourResponse == "2" || optionFourResponse == "tiktok celebrity")
                {
                    OptionSix();
                }
                else
                {
                    Console.WriteLine("I don't understand that command.  Please pick \"1\" or \"2\"");
                    Console.WriteLine("Press Enter to try again");
                    Console.ReadLine();
                    OptionFour();
                }
            }
            public static void OptionFive()
            {
                string optionFiveResponse;
                Console.Clear();
                Console.WriteLine("You arrive in California but need to decide where to stay\n" + 
                    "\n" +
                    "Where do you choose to stay?\n" +
                    "1. Hotel \n" +
                    "2. Airbnb");
                optionFiveResponse = Console.ReadLine().ToLower();
                if (optionFiveResponse == "hotel" || optionFiveResponse == "1")
                {

                    Console.Clear();
                    Console.WriteLine("Sorry. You can't find a hotel room because Millenials killed the hotel industry. \n" +
                        "You are forced to head back home because you can't find a place to stay.");
                    Program.PlayAgain();
                }
                else if (optionFiveResponse == "airbnb" || optionFiveResponse == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations! You throw an amazing house party and all Coachella music artists come and play at your Airbnb!");
                    Program.PlayAgain();
                }
                else
                {
                    Console.WriteLine("I don't understand that command.  Please pick option \"1\" or \"2\"");
                    Console.WriteLine("Press Enter to try again");
                    Console.ReadLine();
                    OptionFive();
                }

            }
            
            public static void OptionSix()
            {
                DiceGame.DiceRoll();
            }
    }
}
