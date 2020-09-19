using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _00_ChallengesConsoleApp
{
    class ChallengeExample
    {
        static void Main(string[] args)
        {
            string firstName = "David";
            string lastName = "Gilchrist";
            int age = 33;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);

            //Array

            string[] array = { "Harry Potter", "Lord of the Rings", "Shawshank Redemption", "Star Wars" };
            Console.WriteLine(array);
            Console.ReadLine();

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
            Console.ReadLine();



            //Sleep

            Console.WriteLine("How many hours of sleep did you get?");
            int sleepHours = Convert.ToInt16(Console.ReadLine());

            if (sleepHours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }

            if (sleepHours >= 8 && sleepHours < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }

            if (sleepHours > 4 && sleepHours < 8)
            {
                Console.WriteLine("Bummer");
            }

            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            Console.ReadLine();

            ////Switch Case "How are you Feeling?"

            Console.WriteLine("How are you feeling today? Great, Good, Okay, or Bad");
            string yourDay = Console.ReadLine();

            switch (yourDay)
            {
                case "Great":
                    Console.WriteLine("That is fantastic");
                    break;
                case "Good":
                    Console.WriteLine("Cool, good to hear");
                    break;
                case "Okay":
                    Console.WriteLine("What is going on?  Can I help:");
                    break;
                case "Bad":
                    Console.WriteLine("Oh no!  I hope it goes better");
                    break;
            }
        }
    }
}
