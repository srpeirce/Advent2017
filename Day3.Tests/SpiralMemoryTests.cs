using Xunit;

namespace Day3.Tests
{
    public class SpiralMemoryTests
    {
        [Theory, 
            InlineData(1, 0),
            InlineData(12, 3),
            InlineData(23, 2),
            InlineData(1024, 31)]
        public void CalculateStepsFromMemoryLocation(int memoryLocation, int expectedSteps)
        {
            var sprialMemory = new SpiralMemory(memoryLocation);
            var memoryBlock = sprialMemory.GetMemoryBlock(memoryLocation);

            Assert.Equal(expectedSteps, memoryBlock.CalculateSteps());
        }

        [Theory,
            InlineData(1, 1),
            InlineData(2, 1),
            InlineData(3, 2),
            InlineData(4, 4),
            InlineData(5, 5),
            InlineData(6, 10),
            InlineData(7, 11),
            InlineData(23, 806)]
        public void CalculateValueFromMemoryLocation(int memoryLocation, ulong expectedValue)
        {
            var sprialMemory = new SpiralMemory(memoryLocation);
            var memoryBlock = sprialMemory.GetMemoryBlock(memoryLocation);

            Assert.Equal(expectedValue, memoryBlock.Value);
        }
    }
}
