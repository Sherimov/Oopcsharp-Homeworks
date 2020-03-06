using System;

namespace Swap_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number:");
            int firstNumber = 0;
            bool numberFromFirstInput = int.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Input the second number:");
            int secondNumber = 0;
            bool numberFromSecondInput = int.TryParse(Console.ReadLine(), out secondNumber);
            if(numberFromFirstInput && numberFromSecondInput)
            {
                Console.WriteLine("Before swap: first number: " + firstNumber + ", second number: " + secondNumber);
                firstNumber = firstNumber * secondNumber;
                secondNumber = firstNumber / secondNumber;
                firstNumber = firstNumber / secondNumber;
                Console.WriteLine("After swap: First number: " + firstNumber + ", second number: " + secondNumber);
            }
            else
            { 
                Console.WriteLine("One of the two inputs is not corect!"); 
            }
            Console.ReadLine();
        }
    }
}
