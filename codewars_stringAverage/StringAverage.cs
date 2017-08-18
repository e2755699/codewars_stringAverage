using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars_stringAverage
{
    class StringAverage
    {
        private readonly string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        internal string Accum(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "n/a";
            }

            return GetStringAverage(input);
        }

        private string GetStringAverage(string input)
        {
            int average = 0;
            int count = 0;

            foreach (var inputNumber in input.Split(' '))
            {
                if (IsGreaterThanNine(inputNumber))
                {
                    return "n/a";
                }
                average += ConvertStringNumberToIntNumber(inputNumber);
                count++;
            }

            return ConvertIntNumberToStringNumber(average/count);
        }

        private string ConvertIntNumberToStringNumber(int average)
        {
            for (var number = 0; number < 10; number++)
            {
                if (average == number)
                {
                    return numbers[number];
                }
            }
            return "";
        }

        private int ConvertStringNumberToIntNumber(string inputNumber)
        {
            for (var number = 0; number < 10 ; number++)
            {
                if (inputNumber.Equals(numbers[number]))
                {
                    return number;
                }
            }
            return 0;
        }

        private bool IsGreaterThanNine(string input)
        {
            foreach (var number in numbers)
            {
                if (input.Equals(number))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
