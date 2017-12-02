using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public static class CaptchaBreaker
    {
        public static string SolveUsingNextNumberMethod(string captcha)
        {
            return SolveIt(captcha, 1);
        }

        public static string SolveUsingHalfwayNumberMethod(string captcha)
        {
            var delta = captcha.Length / 2;
            return SolveIt(captcha, delta);
        }

        private static string SolveIt(string captcha, int delta, int currentPosition = 0, double totalSoFar = 0)
        {
            if (currentPosition >= captcha.Length)
            {
                return totalSoFar.ToString();
            }

            var circularCaptcha = captcha + captcha;

            var thisNumber = char.GetNumericValue(circularCaptcha[currentPosition]);
            var nextNumber = char.GetNumericValue(circularCaptcha[currentPosition + delta]);

            var total = thisNumber == nextNumber ? totalSoFar + thisNumber : totalSoFar;

            return SolveIt(captcha, delta, ++currentPosition, total);
        }
    }
}
