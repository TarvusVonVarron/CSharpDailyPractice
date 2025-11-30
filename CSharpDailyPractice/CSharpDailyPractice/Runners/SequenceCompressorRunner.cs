using System;
using CSharpDailyPractice.SequenceCompressor;

namespace CSharpDailyPractice.Runners
{
    public static class SequenceCompressorRunner
    {
        public static void Run()
        {
            Console.WriteLine("=== Тесты для SequenceCompressor ===");
            foreach (var (input, expected) in SequenceCompressor.SequenceCompressor.GetTestCases())
            {
                var actual = SequenceCompressor.SequenceCompressor.Compress(input);

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
