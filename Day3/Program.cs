using System;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Please enter memory address:");
                if (!int.TryParse(Console.ReadLine(), out int memorySize))
                {
                    Console.WriteLine("Invalid - please enter an integer.");
                }
                var spiralMemory = new SpiralMemory(memorySize);
                var memoryBlock = spiralMemory.GetMemoryBlock(memorySize);
                
                Console.WriteLine($"Steps: {memoryBlock.CalculateSteps()} - Value: {memoryBlock.Value}");
                Console.WriteLine($"First with Value > memorySize (puzzle input): {spiralMemory.Memory.FirstOrDefault(m => m.Value > (ulong)memorySize)?.Value}");
            }
        }
    }
}
