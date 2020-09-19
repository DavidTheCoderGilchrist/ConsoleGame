using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Method
{
    [TestClass]
    public class MethodExamples
    { 
        //Input
        //What we do
        //Output

        //Access Modifer   Return Type   Method Signature (Name and list of paramters)
        public int AddTwoNubmers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        private int FindRemainder(int a, int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;
        }
        [TestMethod]
        public void MethodTests()
        {
            int banana  = AddTwoNubmers(7, 12);
            int sumTwo = AddTwoNubmers(5, 42);

            Assert.AreEqual(19, banana);

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);

            int product = MultiplyTwoNumbers(12, 5);
            Assert.AreEqual(60, product);

            int fruitSalad = DivideTwoNumbers(10, 4);
            Assert.AreEqual(2, fruitSalad);

            int remainder = FindRemainder(10, 4);
            Assert.AreEqual(2, remainder);
          }
    }
}
