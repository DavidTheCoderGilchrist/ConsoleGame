using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace _00_Week2_Challenges
{

    public class MainClass
    {
       
        
        static void Main(string[] args)
        {
                 
            Greeter hello = new Greeter();
            hello.Hello();
            
            Console.ReadKey();
            Console.WriteLine("...(awkward silence)");
            Console.ReadKey();
            hello.Goodbye();
            hello.TimeOfDay();
        }

    }

    public class Greeter
    {
              
        public void Hello()
        {
            Console.WriteLine("Hello!  What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!  " + "Great to meet you.");            
        }

        public void Goodbye()
        {
            Console.WriteLine("Wait what is your name again?");
            Console.WriteLine("Welp it was great to meet you " + name + ".");
        }

        public void TimeOfDay()
        {
           DateTime time = DateTime.Now;

            if (time.Hour < 5)
            {
                Console.WriteLine("Now go to bed!");
            }

            else if (time.Hour < 12)
            {
                Console.WriteLine("Have a Good Morning");
            }

            else if (time.Hour < 17)
            {
                Console.WriteLine("Have a Good Afternoon");
            }

            else if (time.Hour < 20)
            {
                Console.WriteLine("Have a Good Evening");
            }

            else
            {
                Console.WriteLine("Goodnight!");
            }
        }

    }
}
