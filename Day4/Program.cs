using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            var validCount = 0;
            var invalidCount = 0;
            while(true)
            {
                Console.WriteLine("Please enter a PassPhrase:");
                var value = Console.ReadLine();
                var isValid = PassPhrase.TryParse(value, out var passPhrase);

                if (isValid)
                {
                    Console.WriteLine($"It's valid whoohoo! [validCount:{++validCount}]");
                } else
                {
                    Console.WriteLine($"It's not valid :-( [invalidCount:{++invalidCount}]");
                }
                Console.WriteLine("---\n\n");
            }
        }
    }
}
