using System;

namespace _00_ChallengeW1D3_ConditionsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Supercalifragilisticexpialidocious";

            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

            Console.ReadLine();

            foreach (char letter in word)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }

                if (letter == 'l')
                {
                    Console.WriteLine(letter);
                }

                else
                {
                    Console.WriteLine("Not an i or an l");
                }

            }

            Console.ReadLine();

            
            //Bonus

            int numberOfLetters = 0;

            foreach (char letter in word)
            {
                numberOfLetters++;
            }

            Console.WriteLine(numberOfLetters);
                        
        }
    }
}
