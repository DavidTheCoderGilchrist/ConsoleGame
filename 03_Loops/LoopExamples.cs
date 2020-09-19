using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void TestMethod1()
        {
            int studentCount = 15;

            //1 Starting point
            //2 Condition that while true, keeps the loop running
            //3 Body of the loop, what happens each iteration
            //4for //1..........//2...........//3
            for(int i = 0; i < studentCount; i++)  // i = i + 1; -> i++
            {
                //4
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string name = "Eleven Fifst Academy";

            //1 Collection that's being worked on
            //2 Name of the current iteraction being used
            //3 Current Type in the collection
            //4 in keyword, used to seperate the individual and the collection
            //5 Body of the loop

            //foreach //3  //2   //4 //1
            foreach (char letter in name)
            {
                Console.WriteLine(letter); //5
            }
                
        }

        [TestMethod]
        public void WhileLoops()

        {
            int total = 1;

            //1 Loop runs while the condition is true
            //2 The body of the loop

            //while //1
            while (total !=30)
            {
                Console.WriteLine(total);
                total++; // total = total + 1;
            }

        }

        
    }
}
