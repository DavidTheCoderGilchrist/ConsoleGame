﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isfalse = 17 == 5;
        }


        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = false; 
            if (isTrue)
            {
                // Do something here
            }

            int age = 12;

            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're still a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("You're far too young to be on a computer");
            }
            else
            {
                Console.WriteLine("You're not even born yet");
            }

            if (age > 65 && age < 18)
            {
                // And comparison &&
            }

            if (age || age >= 18)
            {
                // Or comparison ||
            }

            if (age == 17)
            {
                // Is Equal To comparison
            }

            if (age != 19)
            {
                // Not equals to
                // ! bang operator
            }

        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;

            switch (age)
            {
                case 18:
                    //Code for if age is 18
                    break;
                case 19:
                    //Code for if age is 19
                    break;
                case 20:
                    //Code for if age is 19
                    break;
                case 21:
                case 22:
                case 23:
                    //Code for 21-23
                    break;
                default:
                    //Catch all code
                    Console.WriteLine("You are not 18-23");
                    break;

            }

        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 37;

            //bool someVariable = (boolean statement ? trueValue : falseValue

            bool isAge = (age == 24) ? true : false;
        }
    }   
}
