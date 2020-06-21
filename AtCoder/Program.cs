using System;

namespace AtCoder
{
    public interface IInputReader
    {
        string Read();
    }

    public interface IOutputWriter
    {
        void Write(string output);
    }

    class ConsoleInputReader : IInputReader
    {
        public string Read() => Console.ReadLine();
    }

    class ConsoleOutputWriter : IOutputWriter
    {
        public void Write(string output) => Console.WriteLine(output);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var reader = new ConsoleInputReader();
            var writer = new ConsoleOutputWriter();
            new Solver(reader, writer).Solve();
        }
    }

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
            var c = _inputReader.Read();
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (alphabets.Contains(c))
            {
                _outputWriter.Write("A");
            }
            else
            {
                _outputWriter.Write("a");
            }
        }

        private static string Read() => Console.ReadLine();
        private static char[] ReadChars() => Array.ConvertAll(Read().Split(), a => a[0]);
        private static int ReadInt() => int.Parse(Read());
        private static long ReadLong() => long.Parse(Read());
        private static double ReadDouble() => double.Parse(Read());
        private static int[] ReadInts() => Array.ConvertAll(Read().Split(), int.Parse);
        private static long[] ReadLongs() => Array.ConvertAll(Read().Split(), long.Parse);
        private static double[] ReadDoubles() => Array.ConvertAll(Read().Split(), double.Parse);
    }
}