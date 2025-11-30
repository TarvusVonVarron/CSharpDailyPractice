using System;
using CSharpDailyPractice.SequenceDecompressor;

namespace CSharpDailyPractice.Runners
{
    public static class SequenceDecompressorRunner
    {
        public static void Run()
        {
            Console.WriteLine("=== Тесты для SequenceCompressor ===");
            foreach (var (input, expected) in SequenceDecompressor.SequenceDecompressor.GetTestCases())
            {
                var actual = SequenceDecompressor.SequenceDecompressor.Decompress(input);

                Console.WriteLine($"Input:    {input}");
                Console.WriteLine($"Expected: {expected}");
                Console.WriteLine($"Actual:   {actual}");
                Console.WriteLine(actual == expected
                    ? "✔ PASS"
                    : "✘ FAIL");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
