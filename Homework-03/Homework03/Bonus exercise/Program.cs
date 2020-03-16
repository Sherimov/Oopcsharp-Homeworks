using System;

namespace Bonus_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number:");
            int numberToGuess = 10;
            while(true)
            {
                Console.WriteLine("Enter your guess: ");
                int numberFromInput ;
                bool checkNumberFromInput = int.TryParse(Console.ReadLine(), out numberFromInput);
                if(!checkNumberFromInput)
                {
                    Console.WriteLine("You have entered a character !");
                    break;
                }
                if(numberFromInput == numberToGuess)
                {
                    Console.WriteLine("Nailed it. Number entered: " + numberToGuess );
                    break;
                }
                else if(numberFromInput > numberToGuess)
                {
                    if(numberToGuess * 2 < numberFromInput) 
                    {
                        Console.WriteLine("Your guess is far to high, number entered: " + numberFromInput);
                    }
                    else
                    {
                        Console.WriteLine("Your guess is a little bit higher, number entered: " + numberFromInput);
                    }
                }
                else
                {
                    if(numberToGuess / 2 > numberFromInput)
                    {
                        Console.WriteLine("Your guess is far to low, number entered: " + numberFromInput);
                    }
                    else
                    {
                        Console.WriteLine("Your guess is a little bit lower, number entered: " + numberFromInput);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
