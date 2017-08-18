using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codewars_stringAverage
{
    [TestClass]
    public class StringAverageTests
    {
        [TestMethod]
        public void InputIsEmpty_shouldReturn_n_div_a()
        {
            var input = string.Empty;
            var expect = "n/a";
            AccumShouldBe(expect, input);
        }

        [TestMethod]
        public void InputIsGreaterThanNine_shoudReturn_n_div_a()
        {
            var input = "ten";
            var expect = "n/a";
            AccumShouldBe(expect, input);
        }

        [TestMethod]
        public void Input_one_shouldReturn_one()
        {
            var input = "one";
            var expect = "one";
            AccumShouldBe(expect, input);
        }

        [TestMethod]
        public void Input_zero_nine_shouldReturn_four()
        {
            var input = "zero nine";
            var expect = "four";
            AccumShouldBe(expect, input);
        }

        [TestMethod]
        public void Input_zero_nine_five_two_shouldReturn_four()
        {
            var input = "zero nine five two";
            var expect = "four";
            AccumShouldBe(expect, input);
        }

        private static void AccumShouldBe(string expect, string input)
        {
            Assert.AreEqual(expect, new Kata().AverageString(input));
        }
    }
}
