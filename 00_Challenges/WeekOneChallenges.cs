using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challenges
{
    [TestClass]
    public class WeekOneChallenges
    {
        [TestMethod]
        public void ChallengeCriteria()
        {
            //Variables
            string firstName = "David";
            string lastName = "Gilchrist";
            int age = 33;

            //Array
    
            string bookOne = "Harry Potter";
            string bookTwo = "Lord of the Rings";
            string movieOne = "Shawshank Redemption";
            string movieTwo = "Star Wars";

            string[] array = {bookOne, bookTwo, movieOne, movieTwo};
            Console.WriteLine(array);

            //Lists

            List<DateTime> listOfDateTime = new List<DateTime>();
            listOfDateTime.Add(DateTime.Now);
            listOfDateTime.Add(new DateTime(2020, 8, 16));
            Console.WriteLine(listOfDateTime);

            //Console age variable 7

            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age % 7);

            //Sleep

            int sleepHours = 4;

            if (sleepHours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }

            else if (sleepHours > 8 && sleepHours < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            
            else if (sleepHours >4 && sleepHours < 8)
            {
                Console.WriteLine("Bummer");
            }

            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }


            Console.WriteLine("How are you feeling today? Great, Good, Okay, or Bad");
            string yourDay = Console.ReadLine();
            
            switch (yourDay);
            {
                string "Great":
                    break;

            }



        }
    }
}
