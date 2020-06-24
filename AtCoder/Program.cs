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
            var inputs = _inputReader.ReadLine().ToLongArray();
            var A = inputs[0];
            var B = inputs[1];
            var syoji = inputs[2];

            Func<long, long> nPrice = (n) => A * n + B * n.ToString().Length;

            var success_max = 0L;
            var failue_min = long.MaxValue;
            var challenge = 1L;
            while (true)
            {
                var price = nPrice(challenge);
                var success = price <= syoji;
                System.Diagnostics.Debug.Print(
                    $"[{success_max}〜({challenge})〜{failue_min}], price {price}, shoji {syoji}, success={success}");

                if (success)
                {
                    var diff = challenge - success_max;
                    success_max = challenge;
                    challenge += diff * 2;
                    if (challenge >= failue_min)
                    {
                        challenge = failue_min - 1;
                    }

                    if (success_max >= 1000000000)
                    {
                        success_max = 1000000000;
                        break;
                    }
                }
                else
                {
                    failue_min = challenge;
                    challenge = (success_max + failue_min) / 2;
                    if (challenge <= success_max)
                    {
                        challenge = success_max + 1;
                    }
                }

                if (success_max + 1 == failue_min)
                {
                    break;
                }
            }

            _outputWriter.WriteLine(success_max.ToString());
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