using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace NextBiggerNumber.Logic
{
    /// <summary>
    /// Class contains methods for working with numbers.
    /// </summary>
    public static class NextBiggerNumber
    {
        /// <summary>
        /// Overload version of method FindNextBiggerNumber.
        /// </summary>
        ///<param name="number">Your number.</param>
        /// <param name="time">Calculation time.</param>
        /// <returns>Next bigger number and time.</returns>
        public static int FindNextBiggerNumber(int number, out double time)
        {
            Stopwatch swatch = new Stopwatch();
            swatch.Start();
            number = FindNextBiggerNumber(number);
            swatch.Stop();
            time = (swatch.Elapsed).Milliseconds;
            return number;
        }

        /// <summary>
        /// Find next bigger number for your number.
        /// </summary>
        ///<param name="number">Your number.</param>
        /// <returns>Next bigger number.</returns>
        public static int FindNextBiggerNumber(int number)
        {
            if (number < 1 || number == int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            int numberToCompare = number;
            int temp = 0;
            int k = 0;

            int firstDigit = number % 10;
            number /= 10;
            int secondDigit = number % 10;

            while (number != 0)
            {
                if (firstDigit > secondDigit)
                {
                    number /= 10;
                    temp *= 10;
                    temp += secondDigit;
                    k++;
                    break;
                }

                else
                {
                    temp *= 10;
                    temp += firstDigit;
                    k++;
                    firstDigit = secondDigit;
                    number = number / 10;
                    secondDigit = number % 10;
                }
            }

            IntegerSort(ref temp);
            number = (number * 10 + firstDigit) * (int)Math.Pow(10, k) + temp;

            if (numberToCompare == number)
            {
                return -1;
            }

            return number;
        }

        /// <summary>
        /// Sorts digits in the number.
        /// </summary>
        public static void IntegerSort(ref int number)
        {
            List<int> list = new List<int>();
            while (number != 0)
            {
                list.Add(number % 10);
                number /= 10;
            }

            list.Sort();

            foreach (int i in list)
            {
                number *= 10;
                number += i;
            }
        }
    }
}
