using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars_stringAverage
{
    class Kata
    {
        private readonly string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        internal string AverageString(string str)
        {
            var strNumbers = str.Split(' ');
            if (IsGreaterThanNineOrIsEmpty(strNumbers))
            {
                return "n/a";
            }

            var average = (int)Math.Floor(strNumbers.Select((x, i) => Array.IndexOf(numbers, x)).Average());

            return numbers[average];
        }

        private bool IsGreaterThanNineOrIsEmpty(string[] strNumbers)
        {
            return strNumbers.Select((x) => !numbers.Contains(x)).Contains(true);
        }
    }
}
