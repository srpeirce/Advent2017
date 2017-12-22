using Xunit;

namespace Day5.Tests
{
    public class InterruptCalculatorTests
    {
        [Fact]
        public void CalculateSteps_PartA()
        {
            var interrupts = new[] {0, 3, 0, 1, -3};

            var actual = InterruptCalculator.CalculateSteps(interrupts, InterruptCalculator.PartAInterruptCalc);

            Assert.Equal(5, actual);
        }

        [Fact]
        public void CalculateSteps_PartB()
        {
            var interrupts = new[] { 0, 3, 0, 1, -3 };

            var actual = InterruptCalculator.CalculateSteps(interrupts, InterruptCalculator.PartBInterruptCalc);

            Assert.Equal(10, actual);
        }
    }
}
