using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTries = 0;
            Random numGen = new Random();
            int num = numGen.Next(1, 101);
            Console.WriteLine("Hello, I am thinking of a number, from 1 to 100, can you guess it?");
            Console.WriteLine("Enter Guess: ");

            string userInput = Console.ReadLine();
            numTries++;
            while (Convert.ToInt32(userInput) != num)
            {
                if (Convert.ToInt32(userInput) < num)
                    Console.WriteLine("Too Low!");

                if (Convert.ToInt32(userInput) > num)
                    Console.WriteLine("Too High!");

                Console.WriteLine("Enter Guess: ");
                userInput = Console.ReadLine();
                numTries++;
            }
            Console.WriteLine("You've Won! It took you: " + numTries + " tries to correctly guess the number! (Press any button to end)");
            Console.ReadKey();
        }
    }
}
