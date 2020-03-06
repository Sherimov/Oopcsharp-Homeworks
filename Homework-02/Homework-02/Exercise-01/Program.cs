using System;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            string askNumber = Console.ReadLine();
            int firstNumber = 0;
            
            bool getFirstNum = int.TryParse(askNumber, out firstNumber);
            if (getFirstNum)
            {
                int secondNumber = 0;
                Console.WriteLine("Enter your second number");
                string askSecondNumber = Console.ReadLine();
                bool getSecondNum = int.TryParse(askSecondNumber, out secondNumber);
                if (getSecondNum)
                {
                    Console.WriteLine("Insert an operator");
                    string askOperator = Console.ReadLine();
                    int resultFromOperation = 0;
                    switch (askOperator)
                    {
                        case "-":
                            resultFromOperation = firstNumber - secondNumber;
                            Console.WriteLine("The result is: " + resultFromOperation);
                            break;
                        case "+":
                            resultFromOperation = firstNumber + secondNumber;
                            Console.WriteLine("The result is: " + resultFromOperation);
                            break;
                        case "*":
                            resultFromOperation = firstNumber * secondNumber;
                            Console.WriteLine("The result is: " + resultFromOperation);
                            break;
                        case "/":
                            resultFromOperation = firstNumber / secondNumber;
                            Console.WriteLine("The result is: " + resultFromOperation);
                            break;
                        default:
                            Console.WriteLine("There is no such operator");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Second number is not valid !!!");
                }

            }
            else
            {
                Console.WriteLine("First Number is not valid !!!");
            }

            Console.ReadLine();
        }
    }
}
