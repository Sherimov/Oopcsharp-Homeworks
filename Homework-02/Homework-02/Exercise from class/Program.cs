using System;

namespace Exercise_from_class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region isLarger, oddEven
            Console.WriteLine("Enter first number:");
            int firstNumber = 0;
            bool inputFromFirstNumber = int.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter second number:");
            int secondNumber = 0;
            bool inputFromSecondNumber = int.TryParse(Console.ReadLine(), out secondNumber);
            if(inputFromFirstNumber && inputFromSecondNumber)
            {
                if(firstNumber > secondNumber)
                {
                    Console.WriteLine("First number: " + firstNumber + " is larger than the second number: " + secondNumber);
                }
                else
                {
                    Console.WriteLine("First number: " + firstNumber + " is smaller than the second number: " + secondNumber);
                }
                if(firstNumber % 2 == 0)
                {
                    Console.WriteLine("First number is even");
                }
                else
                {
                    Console.WriteLine("First Number is odd");
                }
                if(secondNumber % 2 == 0)
                {
                    Console.WriteLine("Second number is even");
                }
                else
                {
                    Console.WriteLine("Second Number is odd");
                }
            }
            else
            {
                Console.WriteLine("One of the two inputs is not corect!");
            }
            Console.ReadLine();
            #endregion

            #region Random number
            Console.WriteLine("Press any key for your lucky number.");
            Console.ReadLine();
            Random randomNumbertoThree = new Random();
            int number = randomNumbertoThree.Next(1, 3);
            switch(number) {
                case 1:
                    Console.WriteLine("Your number: " + number);
                    Console.WriteLine("You got a new car");
                    break;
                case 2:
                    Console.WriteLine("Your number: " + number);
                    Console.WriteLine("You got a new plane");
                    break;
                case 3:
                    Console.WriteLine("Your number: " + number);
                    Console.WriteLine("You got a new bike");
                    break;
                default: Console.WriteLine("NO NUMBER FOR YOU");
                    break;
            };
            Console.ReadLine();
            #endregion
        }
    }
}
