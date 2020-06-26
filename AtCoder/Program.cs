using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            var nums = _inputReader.ReadLine().ToIntArray();
            var result = nums[2] >= nums[0] && nums[2] <= nums[1];
            _outputWriter.WriteLine(result ? "Yes" : "No");
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
        public static string[] ToStringArray(this string text) => text.Split(' ').ToArray();
        public static int ToInt(this string text) => int.Parse(text);
        public static int[] ToIntArray(this string text) => text.Split(' ').Select(txt => txt.ToInt()).ToArray();
        public static long ToLong(this string text) => long.Parse(text);
        public static long[] ToLongArray(this string text) => text.Split(' ').Select(txt => txt.ToLong()).ToArray();
        public static string ToJoinedString(this string[] texts) => string.Join("", texts);
        public static string ToJoinedString(this char[] chars) => string.Join("", chars);
    }

    public struct ModLong : IEquatable<ModLong>
    {
        private const long Mod = 1000000007;
        private readonly long _value;

        public ModLong(long value)
        {
            _value = (value % Mod + Mod) % Mod;
        }

        public bool Equals(ModLong other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            return obj is ModLong other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public static bool operator ==(ModLong left, ModLong right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ModLong left, ModLong right)
        {
            return !left.Equals(right);
        }

        public static ModLong operator +(ModLong left, ModLong right)
        {
            return (ModLong) (left._value + right._value);
        }

        public static ModLong operator -(ModLong left, ModLong right)
        {
            return (ModLong) (left._value - right._value);
        }

        public static ModLong operator *(ModLong left, ModLong right)
        {
            return (ModLong) (left._value * right._value);
        }

        public static ModLong operator /(ModLong left, ModLong right)
        {
            return (ModLong) (left._value * Util.ModInv(right._value, Mod));
        }

        public static explicit operator long(ModLong num)
        {
            return num._value;
        }

        public static explicit operator ModLong(long num)
        {
            return new ModLong(num);
        }

        public override string ToString() => _value.ToString();
    }

    public class ModCombination
    {
        private const int Max = 510000;
        private const long Mod = 1000000007;

        private long[] fac = new long[Max];
        private long[] finv = new long[Max];
        private long[] inv = new long[Max];

        public ModCombination()
        {
            fac[0] = 1;
            fac[1] = 1;
            finv[0] = 1;
            finv[1] = 1;
            inv[1] = 1;
            for (var i = 2; i < Max; i++)
            {
                fac[i] = fac[i - 1] * i % Mod;
                inv[i] = Mod - inv[Mod % i] * (Mod / i) % Mod;
                finv[i] = finv[i - 1] * inv[i] % Mod;
            }
        }

        /// <summary>
        /// mCn 組み合わせ
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public long Combination(long m, long n)
        {
            if (m < n) return 0;
            if (m < 0 || n < 0) return 0;
            return fac[m] * (finv[n] * finv[m - n] % Mod) % Mod;
        }
    }

    public class Util
    {
        /// <summary>
        /// a^n mod を計算する
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="mod"></param>
        /// <returns></returns>
        public static long ModPow(long a, long n, long mod)
        {
            long res = 1;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    res = res * a % mod;
                }

                a = a * a % mod;
                n >>= 1;
            }

            return res;
        }

        /// <summary>
        /// a^{-1} mod を計算する
        /// </summary>
        /// <param name="a"></param>
        /// <param name="mod"></param>
        /// <returns></returns>
        public static long ModInv(long a, long mod)
        {
            return ModPow(a, mod - 2, mod);
        }

        /// <summary>
        /// 階乗
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static long ModFactional(long n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n));
            ModLong result = (ModLong) 1;
            for (var i = 1; i <= n; i++)
            {
                result *= (ModLong) i;
            }

            return (long) result;
        }
    }
}