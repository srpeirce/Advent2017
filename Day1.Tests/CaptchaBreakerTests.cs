using System;
using Xunit;

namespace Day1.Tests
{
    public class CaptchaBreakerTests
    {
        [Theory,
        InlineData("1122", "3"),
        InlineData("1111", "4"),
        InlineData("1234", "0"),
        InlineData("91212129", "9")]
        public void SolveUsingNextNumberMethod(string input, string expected)
        {
            var actual = CaptchaBreaker.SolveUsingNextNumberMethod(input);
            Assert.Equal(expected, actual);
        }

        [Theory,
        InlineData("1212", "6"),
        InlineData("1221", "0"),
        InlineData("123425", "4"),
        InlineData("123123", "12"),
        InlineData("12131415", "4")]
        public void SolveUsingHalfwayNumberMethod(string input, string expected)
        {
            var actual = CaptchaBreaker.SolveUsingHalfwayNumberMethod(input);
            Assert.Equal(expected, actual);
        }
    }
}
