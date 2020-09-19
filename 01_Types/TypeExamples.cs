using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void VauleTypes()
        {
            //  Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallwholeNumber = 16;
            int wholeNumber = 32;
            long largewholeNumber = 64;

            // Decimals

            float floatExample = 1.234567f;
            double doubleExample = 1.23784;
            decimal decimalExample = 1.700000m;

            // Character
            char letter = 'j';

            // Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne / numTwo;
            Console.WriteLine(prod);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);
            Console.WriteLine("Hello");
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            // Strings
            string stringExample = "This is a string.";
            string name = "David";

            string declared;
            declared = "Now it's initialized";

            //Formatting strings
            string concatenate = stringExample + " " + name; //This is a string.David
            string interpolate = $"{name}. Here is the string: {stringExample}."; // David. Here is the string: This is the string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            // Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2020, 8, 12);

            TimeSpan waitTime = now - randomDate;
            Console.WriteLine(waitTime.TotalSeconds);

            //  Collections
            // Arrays
            string anotherExampleString = "Hello World";
            string[] stringArry = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArry);

            // Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");


            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            // Other Collections
            SortedList<int, string> sortedkeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();






        }
    }
}
