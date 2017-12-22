using System;
using System.Linq;

namespace Day5
{
    public class InterruptCalculator
    {
        public static Func<int, int> PartAInterruptCalc = i => i + 1;
        public static Func<int, int> PartBInterruptCalc = i => i >= 3 ? i - 1 : i + 1;

        public static int CalculateSteps(int[] interrupts, Func<int, int> calculateNewInterrupt)
        {
            var steps = 0;
            var nextPosition = 0;
            var workingCopy = interrupts.ToArray();

            while (nextPosition < interrupts.Length)
            {
                var currentInterrupt = workingCopy[nextPosition];
                workingCopy = workingCopy.ToArray();
                workingCopy[nextPosition] = calculateNewInterrupt(currentInterrupt);

                nextPosition = nextPosition + currentInterrupt;
                ++steps;
            }

            return steps;
        }
    }
}
