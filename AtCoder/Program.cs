using System;
using System.Linq;

namespace AtCoder
{
    public class Solver
    {
        private readonly IInputReader _inputReader;
        private readonly IOutputWriter _outputWriter;

        public Solver(IInputReader inputReader, IOutputWriter outputWriter)
        {
            _inputReader = inputReader;
            _outputWriter = outputWriter;
        }

        public void Solve()
        {
            var N = _inputReader.ReadLine().ToInt();
            var numbers = _inputReader.ReadLine().ToLongArray();

            var oddCount = numbers.Count(n => n % 2 == 1);
            var evenCount = numbers.Count(n => n % 2 == 0);

            while (true)
            {
                if (oddCount >= 2)
                {
                    oddCount -= 2;
                    evenCount += 1;
                }
                else if (evenCount >= 2)
                {
                    evenCount -= 2;
                    evenCount += 1;
                }
                else
                {
                    break;
                }
            }

            var result = (oddCount + evenCount) == 1;

            _outputWriter.WriteLine(result ? "YES" : "NO");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new ConsoleInputReader();
            var writer = new ConsoleOutputWriter();
            new Solver(reader, writer).Solve();
        }
    }

    public interface IInputReader
    {
        string ReadLine();
    }

    public interface IOutputWriter
    {
        void WriteLine(string output);
    }

    internal class ConsoleInputReader : IInputReader
    {
        public string ReadLine() => Console.ReadLine();
    }

    internal class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteLine(string output) => Console.WriteLine(output);
    }

    public static class StringExtensions
    {
        public static char ToChar(this string text) => text[0];
        public static long ToInt(this string text) => int.Parse(text);
        public static long ToLong(this string text) => long.Parse(text);
        public static long[] ToLongArray(this string text) => text.Split(' ').Select(txt => txt.ToLong()).ToArray();
    }
}