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
            var n = ReadLong();
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

        private string Read() => _inputReader.ReadLine();
        private char[] ReadChars() => Array.ConvertAll(Read().Split(), a => a[0]);
        private int ReadInt() => int.Parse(Read());
        private long ReadLong() => long.Parse(Read());
        private double ReadDouble() => double.Parse(Read());
        private int[] ReadInts() => Array.ConvertAll(Read().Split(), int.Parse);
        private long[] ReadLongs() => Array.ConvertAll(Read().Split(), long.Parse);
        private double[] ReadDoubles() => Array.ConvertAll(Read().Split(), double.Parse);
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
}