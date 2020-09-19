using System;

namespace _0_ChickenScratch2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            string choice;
            Console.Clear();
            Console.WriteLine("Welcome to your Milennial Adventure! \n" +
                "\n" +
                "You have just gotten a group text from your friends asking if you want to go to Coachella, but you have to leave now!\n" +
                "Do you go? (Yes or No)");
            choice = Console.ReadLine().ToLower();
            if (choice == "yes")
            {
                StartingPoint();
            }
            else if (choice == "no")
            {
                Console.WriteLine("Lame.  Have fun sitting at home in your parent's basement");
                PlayAgain();
            }
            else
            {
                Console.WriteLine("I don't understand that command.  Please pick Yes or No.");
                Console.WriteLine("Please Enter to try again");
                Console.ReadLine();
                
                MainMenu();
            }
        }
        public static void StartingPoint()
        {
            string startingPointResponse;
            Console.Clear();
            Console.WriteLine("Great! How are you going to get there?\n" +
                "Scooter or Uber?");
            startingPointResponse = Console.ReadLine().ToLower();
            if (startingPointResponse == "scooter")
            {
                OptionOne();
            }
            else if (startingPointResponse == "uber")
            {
                OptionTwo();
            }
            else
            {
                Console.WriteLine("I don't understand that command.  Please pick scooter or uber to try again");
                Console.WriteLine("Please Enter to try again");
                Console.ReadLine();
                StartingPoint();
            }
        }
        public static void OptionOne()
        {
            Console.Clear();
            Console.WriteLine("A Lime scooter, huh? So trendy! \n" +
                "Are you going to wear a helmet?\n" + "Yes or No?");
            string optionOneResponse = Console.ReadLine().ToLower();
            if (optionOneResponse == "yes")
            {
                Console.Clear();
                Console.WriteLine("Your friends see you showing up in a super lame helmet and un-invite you to the festival. \n" +
                    "You head back home :( \n" +
                    "");
                //OptionOneExit();
                PlayAgain();
            }
            else if (optionOneResponse == "no")
            {
                OptionThree();
            }
            else
            {
                Console.WriteLine("I don't understand that command.  Please enter Yes or No");
                Console.WriteLine("Please Enter to try again");
                Console.ReadLine();
                OptionOne();
            }
        }
        //public static void OptionOneExit()
        //{
        //    Console.WriteLine("Your friends see you showing up in a super lame helmet and un-invite you to the festival :(");
        //    PlayAgain();
        //}
        public static void OptionTwo()
        {
            Console.Clear();
            Console.WriteLine("Your Uber arrives and you yell \"Hurry I need to get to my friends house right away!\" \n" +
                "As your Uber speeds recklessly down the street the Uber hits a pot hole and gets a flat tire. \n" +
                "\n" +
                "What do you do?  \n" +
                "1. Head back home\n" +
                "2. Go live on Instgram and ask for somone to pick you up");

            string optionTwoResponse = Console.ReadLine().ToLower();

            if (optionTwoResponse == "1")
            {
                Console.Clear();
                Console.WriteLine("Well there is always next year...maybe.\n" +
                    "\n");
                                        
                PlayAgain();
            }
            else if (optionTwoResponse == "2")
            {
                OptionFour();
            }
            else
            {
                Console.WriteLine("I don't understand that command.  Please pick 1 or 2");
                Console.WriteLine("Please Enter to try again");
                Console.ReadLine();
                OptionTwo();
            }
        }
        public static void OptionThree()
        {
            Console.Clear();
            Console.WriteLine("You arrive at your friend's house in style. They're ready to leave. Who do you ride with?\n" + "Your Crush or Your Friends?");
            string optionThreeResponse = Console.ReadLine().ToLower();
            if (optionThreeResponse == "crush" || optionThreeResponse == "your crush")
            {
                //OptionThreeExit();
            }
            else if (optionThreeResponse == "friends" || optionThreeResponse == "your friends")
            {
                OptionFive();
            }
            else
            {
                Console.WriteLine("I don't understand that command.  Please pick Your Crush or Your Friends");
                Console.WriteLine("Please Enter to try again");
                Console.ReadLine();
                OptionThree();
            }
        }
        //public static void OptionThreeExit()
        //{
        //    Console.WriteLine("As you travel through Vegas, you and your crush overcome your Millenial fear of committment, get married, eat avocado toast, and buy souvenirs for your dogs ");
        //    PlayAgain();
        //}
        public static void OptionFour()
        {
            Console.Clear();
            Console.WriteLine("You go live and two people respond!  One is your best friend and the other is a TikTok celebrity \n" +
                "Which one do you responsed to?\n" +
                "1. Friend \n" +
                "2. TikTok Celebrity");
            string optionFourResponse = Console.ReadLine().ToLower();

            if (optionFourResponse == "1")
            {
                Console.Clear();
                Console.WriteLine("Your friend comes to pick you up and you roadtrip it all the way to California while singing all the songs of your favorite artists");
                Console.WriteLine("Press Enter to hop in the car");
                Console.ReadLine();

                OptionFive();
            }
            else if (optionFourResponse == "2")
            {
                OptionSix();
            }
            else
            {
                Console.WriteLine("I don't understand that command.  Please pick 1 or 2");
                Console.WriteLine("Please Enter to try again");
                Console.ReadLine();
                OptionFour();
            }
        }
        public static void OptionFive()
        {
            string optionFiveResponse;
            Console.Clear();
            Console.WriteLine("You arrive in California and are deciding wear to stay\n" + "Do you choose a Hotel or a Airbnb?");
            optionFiveResponse = Console.ReadLine().ToLower();
            if (optionFiveResponse == "hotel")
            {
                //OptionFiveExit();
                Console.WriteLine("Sorry. You Can't find a hotel room because Millenials killed the hotel industry");
                PlayAgain();
            }
            else if (optionFiveResponse == "airbnb")
            {
                //OptionFiveSuccess();
                Console.WriteLine("Congratulations! You throw an amazing house party and all Coachella music artists come and play at your AirBnb!");
                PlayAgain();
            }
            else
            {
                Console.WriteLine("I don't understand that command.  Please pick Hotel or AirBnb");
                Console.WriteLine("Please Enter to try again");
                Console.ReadLine();
                OptionFive();
            }

        }
        //public static void OptionFiveExit()
        //{
        //    Console.WriteLine("Sorry. You Can't find a hotel room because Millenials killed the hotel industry");
        //    PlayAgain();
        //}
        //public static void OptionFiveSuccess()
        //{
        //    Console.WriteLine("Congratulations! You throw an amazing house party and Coachella comes to you!");
        //    PlayAgain();
        //}
        public static void OptionSix()
        {
            Random dice = new Random();
            int randomRoll = dice.Next(1, 6);

            Console.Clear();
            Console.WriteLine("The Celebrity flies down with their personal helicopter to pick you up, but before you take off he says, \n" +
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

                PlayAgain();

            }
            else if (randomRoll == 1 || randomRoll == 3 || randomRoll == 5)
            {
                Console.Clear();
                Console.WriteLine("You rolled a" + " " + randomRoll + "\n" +
                    "\n" +
                    "RATS! The Celebrity puts on his shades and jump back in the helicopter.\n" +
                    "You walk home kicking rocks and listening to your favorite bands on your iPhone\n" +
                    "\n");
               
                PlayAgain();

            }
        }

        public static void PlayAgain()
        {
            
            Console.WriteLine("\n" +
                "Do you want to play again? (Yes or No?)");
            string playAgainResponse = Console.ReadLine().ToLower();
            if (playAgainResponse == "yes" || playAgainResponse == "y")
            {
                MainMenu();
            }
            else if (playAgainResponse == "no" || playAgainResponse == "n")
            {
                Console.WriteLine("Thanks for playing");
            }
            else
            {
                Console.WriteLine("I don't understand that command");
                PlayAgain();
            }
        }
    }
}
