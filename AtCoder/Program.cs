using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
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
            var numbers = _inputReader.ReadLine().ToIntArray().ToList();
            var n = numbers[0];
            var l = numbers[1];
            var words = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var s = _inputReader.ReadLine();
                words.Add(s);
            }

            var text = string.Join("", words.OrderBy(s => s).ToArray());

            _outputWriter.WriteLine(text);
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
        public static int ToInt(this string text) => int.Parse(text);
        public static int[] ToIntArray(this string text) => text.Split(' ').Select(txt => txt.ToInt()).ToArray();
        public static long ToLong(this string text) => long.Parse(text);
        public static long[] ToLongArray(this string text) => text.Split(' ').Select(txt => txt.ToLong()).ToArray();
    }
}