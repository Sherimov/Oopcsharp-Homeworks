using System;

namespace Bonus_exercise___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 7
            Console.WriteLine("Exercise 7:");
            char[] reverseArray = new char[4] { 'a', 'b', 'c', 'd' };
            for (int i = 0; i < reverseArray.Length; i++)
            {
                Console.WriteLine("Original array: " + reverseArray[i]);
            }
            Array.Reverse(reverseArray);
            for (int i = 0; i < reverseArray.Length; i++)
            {
                Console.WriteLine("Reversed array: " + reverseArray[i]);
            }
            #endregion

            #region Task 8 
            int[] firstArray = new int[] { };
            int[] secondArray = new int[] { };

            while (true)
            {
                Console.WriteLine("Add a number in the first array: ");
                int numberFrominput;
                bool checkNumberFromInput = int.TryParse(Console.ReadLine(), out numberFrominput);
                if (!checkNumberFromInput)
                {
                    Console.WriteLine("Error... Enter a number");
                    break;
                }
                Array.Resize(ref firstArray, firstArray.Length + 1);
                firstArray[firstArray.Length - 1] = numberFrominput;

                Console.WriteLine("Do you want to continue ? Y/N");
                string askForContinuance = Console.ReadLine();
                if (askForContinuance.ToUpper() == "Y")
                {
                    continue;
                }
                if (askForContinuance.ToUpper() == "N")
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Add a number in the second array: ");
                int numberFrominput;
                bool checkNumberFromInput = int.TryParse(Console.ReadLine(), out numberFrominput);
                if (!checkNumberFromInput)
                {
                    Console.WriteLine("Error... Enter a number");
                    break;
                }
                Array.Resize(ref secondArray, secondArray.Length + 1);
                secondArray[secondArray.Length - 1] = numberFrominput;

                Console.WriteLine("Do you want to continue ? Y/N");
                string askForContinuance = Console.ReadLine();
                if (askForContinuance.ToUpper() == "Y")
                {
                    continue;
                }
                if (askForContinuance.ToUpper() == "N")
                {
                    break;
                }
            }
            bool isIdentical = true;
            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("The arrays are not identical");
            }

            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (!firstArray[i].Equals(secondArray[i]))
                    {
                        isIdentical = false;
                    }
                }
            }
            if (isIdentical)
            {
                Console.WriteLine("The arrays are identical");
            }
            else
            {
                Console.WriteLine("The arrays are not identical");
            }
            #endregion

            #region Task 9
            int numberForLooping = 1000;
            for (int i = 1; i <= numberForLooping; i++)
            {
                int sum = 0;
                int n = i;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }

                if (i % sum == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region Task 10
            for (int i = 1; i <= 1000; i++)
            {
                int product = 1;
                int n = i;
                int k;
                while (n != 0)
                {
                    k = n % 10;
                    n /= 10;
                    product *= k;
                }

                if (product != 0 && i % product == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region Task 11
            for (int i = 10; i <= 99; i++)
            {
                int n = i;
                int firstDigit = n / 10;
                int secondDigit = n % 10;
                if (firstDigit > secondDigit)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region TASK 12
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    string fizzBuzz = i.ToString("Fizz Buzz");
                    Console.WriteLine(fizzBuzz);

                }
                else if (i % 5 == 0)
                {
                    string buzz = i.ToString("Buzz");
                    Console.WriteLine(buzz);
                }
                else if (i % 3 == 0)
                {
                    string fizz = i.ToString("Fizz");
                    Console.WriteLine(fizz);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            Console.ReadLine();
        }
    }
}
