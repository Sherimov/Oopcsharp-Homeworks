using System;

namespace Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = 0;
            bool askForFirstNumber = int.TryParse(Console.ReadLine(), out firstNumber);
            if(askForFirstNumber)
            {
                Console.WriteLine("Enter the second number:");
                int secondNumber = 0;
                bool askForSecondNumber = int.TryParse(Console.ReadLine(), out secondNumber);
                if (askForSecondNumber)
                {
                    Console.WriteLine("Enter the third number:");
                    int thirdNumber = 0;
                    bool askForThirdNumber = int.TryParse(Console.ReadLine(), out thirdNumber);
                    if(askForThirdNumber)
                    {
                        Console.WriteLine("Enter the fourth number:");
                        int fourthNumber = 0;
                        bool askForFourthNumber = int.TryParse(Console.ReadLine(), out fourthNumber);
                        if(askForFourthNumber)
                        {
                            int averageOfFourNumbers = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
                            Console.WriteLine("The average of " + firstNumber  +", " + secondNumber + ", "+ thirdNumber + ","+ fourthNumber + " is: " + averageOfFourNumbers);
                        }
                        else
                        {
                            Console.WriteLine("You haven't entered a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You haven't entered a number");
                    }
                }
                else
                {
                    Console.WriteLine("You haven't entered a number");
                }
            }
            else
            {
                Console.WriteLine("You haven't entered a number");
            }
            Console.ReadLine();
        }
    }
}
