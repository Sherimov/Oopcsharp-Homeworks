using System;
using System.Threading;

namespace Bonus_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Guess the number");
                Thread.Sleep(1000);
                Console.WriteLine("Select difficulty:\nEasy\nNormal\nHard");
                string setDifficulty = Console.ReadLine();
                
                int attempts = 1;
                int numberOfTries = 0;
                Random randomNumberGenerated = new Random();
                int numberToGuess = 0;
                int maxNumber;
                string message = "You have {0} tries, and should guess the number from 0 to {1} !";

                if (setDifficulty.ToLower() == "easy")
                {
                    numberOfTries = 9;
                    maxNumber = 100;
                    numberToGuess = randomNumberGenerated.Next(0, maxNumber);
                    Console.WriteLine(string.Format(message, numberOfTries, maxNumber) );
                    Thread.Sleep(500);
                }
                if (setDifficulty.ToLower() == "normal")
                {
                    numberOfTries = 7;
                    maxNumber = 500;

                    numberToGuess = randomNumberGenerated.Next(0, maxNumber);
                    Console.WriteLine(string.Format(message, numberOfTries, maxNumber));
                    Thread.Sleep(500);
                }
                if (setDifficulty.ToLower() == "hard")
                {
                    numberOfTries = 5;
                    maxNumber = 1000;
                    numberToGuess = randomNumberGenerated.Next(0, maxNumber);
                    Console.WriteLine(string.Format(message, numberOfTries, maxNumber));

                    Thread.Sleep(500);
                }
                while (attempts <= numberOfTries)
                {
                    //if (attempts > numberOfTries)
                    //{
                    //    Console.WriteLine("Game over");
                    //    break;
                    //}
                    Console.WriteLine("Enter your guess: ");
                    //bool checkNumberFromInput = int.TryParse(Console.ReadLine(), out int inputNumber);
                   if (!int.TryParse(Console.ReadLine(), out int inputNumber))
                   {
                        Console.WriteLine("You have entered a character !");
                        continue;
                   }
                   if (numberToGuess == inputNumber && attempts == 1)
                   {
                        Console.WriteLine("Lucky Guess " + numberToGuess);
                        break;
                   }
                   if (numberToGuess == inputNumber)
                   {
                        Console.WriteLine("Nailed it. Number entered: " + numberToGuess);
                        break;
                   }
                   if (numberToGuess * 2 < inputNumber)
                   {
                       attempts++;
                       Console.WriteLine("Your guess is far to high, number entered: " + inputNumber);
                       continue;
                   }
                   if (numberToGuess < inputNumber)
                   {
                       attempts++;
                       Console.WriteLine("Your guess is a little bit higher, number entered: " + inputNumber);
                       continue;
                   }
                   if (numberToGuess / 2 > inputNumber)
                   {
                       attempts++;
                       Console.WriteLine("Your guess is far to low, number entered: " + inputNumber);
                       continue;
                   }
                   if (numberToGuess > inputNumber)
                   {
                       attempts++;
                       Console.WriteLine("Your guess is a little bit lower, number entered: " + inputNumber);
                       continue;
                   }
                }
                Console.WriteLine("Game over");

                Console.WriteLine("Do you want to restart the game ? (y/n)");
                string answer = Console.ReadLine();
                if(answer.ToLower() == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
           
            
          
            Console.ReadLine();
        }
    }
}
