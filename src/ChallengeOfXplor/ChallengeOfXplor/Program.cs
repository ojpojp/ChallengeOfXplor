using System;

namespace ChallengeOfXplor
{
    class Program
    {
        private static string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", 
            "ten", "eleven","twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static string[] tens = { "", "", "twenty", "thirty", "forty","fifty", "sixty", "seventy", "eighty", "ninety" };

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Convert(i));
            }
            Console.ReadKey();
        }

        public static string Convert(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new ArgumentException("this function accepts a number between 1 and 100 (inclusive)");
            }

            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (IsPrime(number))
            {
                return "PRIME";
            }
            else
            {
                return NumberToString(number);
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }

            int num = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= num; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Convert number into string between 1 and 100 (inclusive)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string NumberToString(int number)
        {
            string result = "";

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException("this function accepts a number between 1 and 100 (inclusive)");
            }
            else if (number < 20)
            {
                result = ones[number];
            }
            else if (number < 100)
            {
                result = string.Format("{0}{1}",  
                    tens[number / 10], 
                    number % 10 > 0 ? " " + NumberToString(number % 10) : "");
            }
            else if (number == 100)
            {
                result = "one hundred";
            }

            return result;
        }
    }
}