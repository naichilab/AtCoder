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
            var n = _inputReader.ReadLine().ToLong();
            var alphabets = "abcdefghijklmnopqrstuvwxyz";
            var result = "";
            while (n > 0)
            {
                n -= 1;
                var a = (int) (n % 26);
                n /= 26;

                var c = alphabets[a];
                result = c + result;
            }

            _outputWriter.WriteLine(result);
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
    }
}