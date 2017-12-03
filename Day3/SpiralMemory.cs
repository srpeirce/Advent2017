using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    public class SpiralMemory
    {
        public IEnumerable<MemoryBlock> Memory => _memory.AsEnumerable();
        private List<MemoryBlock> _memory;

        public SpiralMemory(int totalMemory)
        {
            var memoryBlock = MemoryBlock.First().WithValue(1);
            _memory = new List<MemoryBlock>()
            {
                memoryBlock
            };

            var haveSeenFirstValueLargerThanTotalMemory = false;
            for (var i = 1; i < totalMemory; i++)
            {
                memoryBlock = memoryBlock.Next();
                var value = CalculateValue(memoryBlock, _memory);

                memoryBlock = memoryBlock.WithValue(value);
                _memory.Add(memoryBlock);

                Console.WriteLine($"Created MemoryBlock: {memoryBlock.Address} or {totalMemory}");

                if (!haveSeenFirstValueLargerThanTotalMemory && memoryBlock.Value > (ulong)totalMemory)
                {
                    Console.WriteLine($"MemoryBlock: {memoryBlock.Address} With value {memoryBlock.Value} is " +
                        $"greater than totalMemory({totalMemory})");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    haveSeenFirstValueLargerThanTotalMemory = true;
                }
            }
        }
        public MemoryBlock GetMemoryBlock(int address)
        {
            var memoryBlock = _memory.First(m => m.Address == address);
            return memoryBlock;
        }

        private ulong CalculateValue(MemoryBlock memory, List<MemoryBlock> allMemory)
        {
            var touchingCoords = memory.Coords.GetTouchingCoords();
            var total = allMemory.Where(m => touchingCoords.Contains(m.Coords))
                .Select(m => m.Value)
                .Aggregate((totalSoFar, next) => totalSoFar + next);

            return total;
        }
    }
}
