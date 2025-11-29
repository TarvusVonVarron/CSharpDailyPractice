using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace CSharpDailyPractice.SequenceCompressor
{
    public static class SequenceCompressor
    {
        /// <summary>
        /// Принимает строку чисел через пробел и возвращает сжатую последовательность.
        /// Пример: "1 1 1 2 2" -> "1(3) 2(2)"
        /// </summary>
        public static string Compress(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var splittedInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();

            string lastItem = splittedInput[0];
            int count = 1;

            for (int i = 1; i < splittedInput.Length; i++)
            {
                if (lastItem != splittedInput[i])
                {
                    sb.Append($"{lastItem}({count}) ");
                    lastItem = splittedInput[i];
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            sb.Append($"{lastItem}({count}) ");
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Тестовые данные для самостоятельной проверки.
        /// </summary>
        public static IEnumerable<(string Input, string Expected)> GetTestCases()
        {
            yield return ("1 1 1 2 2 3 1 1", "1(3) 2(2) 3(1) 1(2)");
            yield return ("5 5 5 5 5", "5(5)");
            yield return ("9 8 8 7 7 7 6 6 9 9 9 9", "9(1) 8(2) 7(3) 6(2) 9(4)");
            yield return ("0 0 1 1 1 0 0 0 0 2", "0(2) 1(3) 0(4) 2(1)");
            yield return ("3 3 4 5 5 6 7 7 7 7 1", "3(2) 4(1) 5(2) 6(1) 7(4) 1(1)");
        }
    }
}
