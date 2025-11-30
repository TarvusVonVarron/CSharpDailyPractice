using System;
using CSharpDailyPractice.Runners;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выбери задачу для запуска:");
            Console.WriteLine("1 - SequenceCompressor (сжатие последовательности)");
            Console.WriteLine("2 - SequenceDecompressor (разжатие последовательности)");
            Console.WriteLine("0 - Выход");
            Console.Write("Ввод: ");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    SequenceCompressorRunner.Run();
                    break;

                case "2":
                    SequenceDecompressorRunner.Run();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Неизвестная команда. Попробуй ещё раз.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Нажми Enter, чтобы продолжить...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
