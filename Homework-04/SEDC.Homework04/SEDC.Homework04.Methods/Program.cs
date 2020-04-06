using System;

namespace SEDC.Homework04.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 0
            Console.WriteLine(Substring());
            #endregion

            #region Task 1
            Console.WriteLine(Palindrome("tostet"));
            #endregion

            #region Task 2
            int[] numbers = new int[5] { 1, 46, 3, 16, 8 };
            Console.WriteLine(largestNumber(numbers));
            #endregion

            #region Task 3
            string text = "41254.7. The first two digits of the stardate are always 41. The 4 stands for 24th century, the 1 indicates first season.";
            Console.WriteLine(DigitCounter(text));
            Console.WriteLine(VowelCounter(text));
            #endregion

            #region Task 4
            string reverseText = "Test daLi Ke gi SmeNi vO sProTIvnI";
            Console.WriteLine(ChangeCharacterCase(reverseText));
            #endregion

            #region Task 5
            Console.WriteLine(charType('['));
            #endregion
            #region Task 6
            Console.WriteLine(subStringCounter("how", "arehowuashowirehowhfushowjdsauehowasdet"));
            #endregion

            #region Task 7
            Console.WriteLine(raisingInteger(3, 4));
            #endregion
            #region Task 8
            DateTime birthdate = new DateTime(1993, 4, 5);
            AgeCalculator(birthdate);
            #endregion


            Console.ReadLine();
        }

        public static string Substring()
        {
            string msg = "Hello from SEDC Codecademy v7.0";
            Console.WriteLine("enter a number: ");
            string newString = String.Empty;
            if(int.TryParse(Console.ReadLine(), out int input) && input > 0 && input < msg.Length)
            {
                newString = msg.Substring(input);
            }
            else
            {
                Console.WriteLine("You need to print a number bigger than 0 and smaller than " + msg.Length);
            }
            return $"The first character of the new string is: {newString.Substring(0,1)}, and the length of the new string is {newString.Length}";
        }

        public static string Palindrome(string word)
        {
            int length = word.Length;
            for(int i =0; i < length /2; i++)
            {
                if (word[i] != word[length - i - 1])
                    return "The word is not palindrome";
            }
            return $"The word is palindrome";
        }

        public static int largestNumber(int[] numbers)
        {
            int largestNumber = 0;
            foreach(int number in numbers)
            {
                if(number > largestNumber)
                {
                    largestNumber = number;
                }
            }
            return largestNumber;
        }

        public static string DigitCounter(string text)
        {
            int counter = 0;
            foreach(char digit in text)
            {
                if (Char.IsDigit(digit))
                {
                    counter++;
                }
            }
            return $"There are {counter} digits in this text.";
        }

        public static string VowelCounter(string text)
        {
            int counter = 0;
            foreach(char vowel in text)
            {
                if ("aeiou".Contains(vowel))
                {
                    counter++;
                }
            }
            return $"There are {counter} vowels in this text.";
        }

        public static string ChangeCharacterCase(string text)
        {
            Console.WriteLine($"Before changing characters: {text}");
            string newText = String.Empty;
            foreach (char character in text)
            {
                if (Char.IsLower(character))
                {
                    newText += Char.ToUpper(character);
                }
                else
                {
                    newText += Char.ToLower(character);
                }
            }
            return $"After changing characters:  {newText}";
        }

        public static string charType(char a)
        {
            if (!Char.IsLetter(a))
            {
                return $"The character '{a}' is not alphabetical character";
            }
            if (Char.IsUpper(a))
            {
                return $"The character '{a}' is an alphabetical character and is uppercase";
            }
            else
            {
                return $"The character '{a}' is an alphabetical character and is lowercase";
            }
        }

        public static int subStringCounter(string sub, string text)
        {
            int subLength = sub.Length;
            int textLength = text.Length;
            int counter = 0;

            for (int i = 0; i <= textLength - subLength; i++)
            {
                int j;
                for (j = 0; j < subLength; j++)
                {
                    if (text[i + j] != sub[j])
                    {
                        break;
                    }
                }

                if (j == subLength)
                {
                    counter++;
                    j = 0;
                }
            }
            return counter;
        }

        public static string raisingInteger(int number, int exp)
        {
            int result = 1;
            for(int i=1; i <= exp; i++)
            {
                result *= number;
            }
            return $"The raising of {number} for {exp} times is: {result}";
        }

        public static void AgeCalculator(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if(DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age -= 1;
            }
            Console.WriteLine($"You have {age} ages.");
        }
    }
}
