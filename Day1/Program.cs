using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating...beepbopbeepbopbeepbop...");

            var captcha = args[0];

            Console.WriteLine($"NextNumberMethod Result: {CaptchaBreaker.SolveUsingNextNumberMethod(captcha)}");
            Console.WriteLine($"HalfwayNumberMethod Result: {CaptchaBreaker.SolveUsingHalfwayNumberMethod(captcha)}");
            Console.ReadKey();
        }
    }
}
