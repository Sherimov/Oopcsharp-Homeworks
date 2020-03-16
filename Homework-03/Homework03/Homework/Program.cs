using System;
using System.Threading;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SumOfEven
            Console.WriteLine("Test data!");
            Thread.Sleep(1000);
            int[] numbersArray = new int[] { };
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Enter six integer:");
                for (int i = 0; i < 6; i++)
                {
                    int numberFromInput;
                    bool checkNumber = int.TryParse(Console.ReadLine(), out numberFromInput);
                    if (checkNumber)
                    {
                        Array.Resize(ref numbersArray, numbersArray.Length + 1);
                        numbersArray[numbersArray.Length - 1] = numberFromInput;
                        continue;
                    }
                }
                if(numbersArray.Length == 6)
                {
                    break;
                }
            }
            for(int i = 0; i < numbersArray.Length; i ++)
            {
                if(numbersArray[i] %2 == 0)
                {
                    sum += numbersArray[i];
                }
            }
            Console.WriteLine("Total sum of even numbers: " + sum);
            #endregion

            #region Student Group
            Thread.Sleep(2000);
            string[] studentsG1 = new string[] {"Mitko", "Darko", "Kire", "Danica", "Miki" };
            string[] studentsG2 = new string[] { "Miroljub", "Marija", "Mirosla", "Daniel", "Elena" };
            Console.WriteLine("Enter student group number: 1 or 2 :");
            int numberInput = int.Parse(Console.ReadLine());
            if (numberInput == 1)
            {
                for(int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine("Students from G1: " + studentsG1[i]);
                }
            }
            else if (numberInput == 2)
            {
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine("Students from G2: " + studentsG2[i]);
                }
            }
            else
            {
                Console.WriteLine("You have entered a wrong value !!!!");
            }
            #endregion
            Console.ReadLine();
        }
    }
}
