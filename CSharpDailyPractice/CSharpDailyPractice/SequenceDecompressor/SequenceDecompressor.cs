using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDailyPractice.SequenceDecompressor
{
    public static class SequenceDecompressor
    {
        public static string Decompress(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            StringBuilder sb = new StringBuilder();

            var splittedInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in splittedInput)
            {
                int openIndex = str.IndexOf('(');
                int closeIndex = str.IndexOf(')');

                string item = str.Substring(0, openIndex);
                int count = int.Parse(str.Substring(openIndex + 1, closeIndex - (openIndex + 1)));

                for (int i = 0; i < count; i++)
                {
                    sb.Append(item);
                    sb.Append(' ');
                }
            }
            

            return sb.ToString().Trim();
        }

        /// <summary>
        /// Тестовые данные для самостоятельной проверки.
        /// </summary>
        public static IEnumerable<(string Input, string Expected)> GetTestCases()
        {
            yield return ("1(3) 2(2) 3(1) 1(2)", "1 1 1 2 2 3 1 1");
            yield return ("5(5)", "5 5 5 5 5");
            yield return ("9(1) 8(2) 7(3) 6(2) 9(4)", "9 8 8 7 7 7 6 6 9 9 9 9");
            yield return ("0(2) 1(3) 0(4) 2(1)", "0 0 1 1 1 0 0 0 0 2");
            yield return ("3(2) 4(1) 5(2) 6(1) 7(4) 1(1)", "3 3 4 5 5 6 7 7 7 7 1");
        }
    }
}
