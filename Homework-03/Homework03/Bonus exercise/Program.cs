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
                Console.WriteLine(
                    "Select difficulty: " + " " + "Easy" + " " + "Normal" + " " + "Hard");
                string setDifficulty = Console.ReadLine();
                
                int attempts = 0;
                int numberOfTries = 0;
                Random randomNumberGenerated = new Random();
                int numberToGuess = 0;
                if (setDifficulty.ToLower() == "easy")
                {
                    numberOfTries = 8;
                    numberToGuess = randomNumberGenerated.Next(0, 100);
                    Console.WriteLine("You have 9 tries, and should guess the number from 0 to 100 !");
                    Thread.Sleep(500);
                }
                if (setDifficulty.ToLower() == "normal")
                {
                    numberOfTries = 6;
                    numberToGuess = randomNumberGenerated.Next(0, 500);
                    Console.WriteLine("You have 7 tries, and should guess the number from 0 to 500 !");
                    Thread.Sleep(500);
                }
                if (setDifficulty.ToLower() == "hard")
                {
                    numberOfTries = 4;
                    numberToGuess = randomNumberGenerated.Next(0, 1000);
                    Console.WriteLine("You have 5 tries, and should guess the number from 0 to 1000 !");
                    Thread.Sleep(500);
                }
                while (true)
                {
                    if (attempts > numberOfTries)
                    {
                        Console.WriteLine("Game over");
                        break;
                    }
                    Console.WriteLine("Enter your guess: ");
                    int inputNumber;
                    bool checkNumberFromInput = int.TryParse(Console.ReadLine(), out inputNumber);
                   if (!checkNumberFromInput)
                   {
                        Console.WriteLine("You have entered a character !");
                        continue;
                   }
                   if (numberToGuess == inputNumber && attempts == 0)
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
