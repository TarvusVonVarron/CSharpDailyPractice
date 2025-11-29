using CSharpDailyPractice.SequenceCompressor;

class Program
{
    public static void Main()
    {
        foreach (var test in SequenceCompressor.GetTestCases())
        {
            var actual = SequenceCompressor.Compress(test.Input);

            Console.WriteLine($"Input:    {test.Input}");
            Console.WriteLine($"Expected: {test.Expected}");
            Console.WriteLine($"Actual:   {actual}");
            Console.WriteLine(actual == test.Expected
                ? "✔ PASS"
                : "✘ FAIL");
            Console.WriteLine(new string('-', 40));
        }
    }
}
