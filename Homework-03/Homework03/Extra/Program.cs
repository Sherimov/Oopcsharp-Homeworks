using System;

namespace Extra
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            Console.WriteLine("Enter a number:");
            int numberFromInput;
            bool checkNumberFromInput = int.TryParse(Console.ReadLine(), out numberFromInput);
            int[] arrayOfNumberInput = new int[] { };
            if (!checkNumberFromInput)
            {
                Console.WriteLine("Enter a number: ");
                if (numberFromInput < 2)
                {
                    Console.WriteLine("number must be bigger than 2");
                }
            }
            for (int i = 0; i <= numberFromInput; i++)
            {
                Array.Resize(ref arrayOfNumberInput, arrayOfNumberInput.Length + 1);
                arrayOfNumberInput[arrayOfNumberInput.Length - 1] = i;
                if (arrayOfNumberInput[i] % 3 == 0)
                {
                    Console.WriteLine("Printing numbers: " + arrayOfNumberInput[i]);
                }
            }

            #endregion

            #region Task 2
            Console.WriteLine("Enter a number:");
            int secondNumberFromInput;
            bool checkSecondNumberFromInput = int.TryParse(Console.ReadLine(), out secondNumberFromInput);
            int[] arrayOfSecondNumberInput = new int[] { };

            if (!checkSecondNumberFromInput)
            {
                Console.WriteLine("Enter a number: ");
                if (secondNumberFromInput < 5)
                {
                    Console.WriteLine("number must be bigger than 5");
                }
            }
            for (int i = 0; i <= secondNumberFromInput; i++)
            {
                Array.Resize(ref arrayOfSecondNumberInput, arrayOfSecondNumberInput.Length + 1);
                arrayOfSecondNumberInput[arrayOfSecondNumberInput.Length - 1] = i;
                if (arrayOfSecondNumberInput[i] % 2 == 0 || arrayOfSecondNumberInput[i] % 3 == 0)
                {
                    Console.WriteLine("Printing numbers: " + arrayOfNumberInput[i]);
                }
            }
            #endregion

            #region Task 3
            Console.WriteLine("Enter a number with two or more digits: ");
            int thirdNumberFromInput;
            bool checkThirdNumber = int.TryParse(Console.ReadLine(), out thirdNumberFromInput);
            if (!checkThirdNumber)
            {
                Console.WriteLine("Error");
            }

            int product = 1;
            while (thirdNumberFromInput != 0)
            {
                product = product * (thirdNumberFromInput % 10);
                thirdNumberFromInput = thirdNumberFromInput / 10;
            }
            Console.WriteLine("The product of the digits of number: " + thirdNumberFromInput + ", is: " + product);
            #endregion

            #region Task 4
            Console.WriteLine("Enter a number: ");
            int numberFourInput = int.Parse(Console.ReadLine());
            int sumOfEven = 0;
            for(int i = 1; i <= numberFourInput; i++)
            {
                
                if(i % 2 == 0)
                {
                    sumOfEven += i;
                }
                
            }
            Console.WriteLine(sumOfEven);
            #endregion

            #region Task 5
            Console.WriteLine("Enter a number: ");
            int numberFiveInput = int.Parse(Console.ReadLine());
            int sumOfOdd = 0;
            for (int i = 1; i <= numberFiveInput; i++)
            {
                
                if(i % 2 != 0)
                {
                    sumOfOdd += i;
                }

            }
            Console.WriteLine(sumOfOdd);
            #endregion
            #region Task 6
            Console.WriteLine("Enter a number: ");
            int numberSixInput = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;
            for (int i = 1; i <= numberSixInput; i++)
            {

                if (i % 5 == 0)
                {
                    sumOfNumbers += i;
                }

            }
            Console.WriteLine(sumOfNumbers);
            #endregion
            Console.ReadLine();
        }
    }
}
