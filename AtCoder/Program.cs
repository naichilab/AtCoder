using System;
using System.Linq;

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
            var line1 = ReadInts();
            var line2 = ReadInts();
            var K = line1[1];
            var result = line2.OrderBy(n => n).Take(K).Sum();
            _outputWriter.Write(result.ToString());
        }

        private string Read() => _inputReader.Read();
        private char[] ReadChars() => Array.ConvertAll(Read().Split(), a => a[0]);
        private int ReadInt() => int.Parse(Read());
        private long ReadLong() => long.Parse(Read());
        private double ReadDouble() => double.Parse(Read());
        private int[] ReadInts() => Array.ConvertAll(Read().Split(), int.Parse);
        private long[] ReadLongs() => Array.ConvertAll(Read().Split(), long.Parse);
        private double[] ReadDoubles() => Array.ConvertAll(Read().Split(), double.Parse);
    }
}