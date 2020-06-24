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
            var numbers = _inputReader.ReadLine().ToIntArray();
            var H = numbers[0];
            var W = numbers[1];
            var A = numbers[2];
            var B = numbers[3];

            var h1 = H - A;
            var w1 = B + 1;
            var h2 = H;
            var w2 = W - B;

            var total = 0L;
            for (int i = 0; i < h1; i++)
            {
                var tate1 = i;
                var yoko1 = (w1 - 1);
                var patternCount1 = Util.Combination(tate1 + yoko1, tate1);

                var tate2 = h2 - 1 - i;
                var yoko2 = w2 - 1;
                var patternCount2 = Util.Combination(tate2 + yoko2, tate2);

                total += (patternCount1 * patternCount2);
            }

            _outputWriter.WriteLine(total.ToString());
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

    public class Util
    {
        /// <summary>
        /// 階乗
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static long Factional(long n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n));

            if (n == 0) return 1;
            var result = 1;
            for (var i = 1; i <= n; i++)
            {
                result = checked(result * i);
            }

            return result;
        }

        /// <summary>
        /// 組み合わせ
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static long Combination(long m, long n)
        {
            if (m <= 0) throw new ArgumentOutOfRangeException(nameof(m));
            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n));
            if (m < n) throw new ArgumentOutOfRangeException(nameof(n));

            return Factional(m) / (Factional(n) * Factional(m - n));
        }
    }
}