﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text.RegularExpressions;

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
            var numbers = _inputReader.ReadLine().ToIntArray();
            var dict = new Dictionary<int, List<int>>();
            foreach (var n in numbers)
            {
                var key = n % 200;
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<int>());
                }

                dict[key].Add(n);
            }

            long cnt = 0;
            foreach (var kvp in dict)
            {
                var nums = kvp.Value;
                var numsCount = nums.Count();
                cnt += Combination.nCk(numsCount, 2);
            }

            _outputWriter.WriteLine(cnt.ToString());
        }
    }


    public static class Combination
    {
        /// <summary>
        /// 組み合わせ (n >= k)
        /// </summary>
        public static long nCk(long n, long k)
        {
            if (n < k) return 0;
            if (n == k) return 1;
            long x = 1;
            for (long i = 0; i < k; i++)
            {
                x = x * (n - i) / (i + 1);
            }

            return x;
        }


        public static IEnumerable<T[]> Enumerate<T>(IEnumerable<T> items, int k, bool withRepetition)
        {
            if (k == 1)
            {
                foreach (var item in items)
                    yield return new T[] {item};
                yield break;
            }

            foreach (var item in items)
            {
                var leftside = new T[] {item};

                // item よりも前のものを除く （順列と組み合わせの違い)
                // 重複を許さないので、unusedから item そのものも取り除く
                var unused = withRepetition ? items : items.SkipWhile(e => !e.Equals(item)).Skip(1).ToList();

                foreach (var rightside in Enumerate(unused, k - 1, withRepetition))
                {
                    yield return leftside.Concat(rightside).ToArray();
                }
            }
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

        public static (string, string) ToString2(this string text)
        {
            var arr = text.ToStringArray();
            return (arr[0], arr[1]);
        }

        public static (string, string, string) ToString3(this string text)
        {
            var arr = text.ToStringArray();
            return (arr[0], arr[1], arr[2]);
        }

        public static (int, int) ToInt2(this string text)
        {
            var arr = text.ToIntArray();
            return (arr[0], arr[1]);
        }

        public static (int, int, int) ToInt3(this string text)
        {
            var arr = text.ToIntArray();
            return (arr[0], arr[1], arr[2]);
        }

        public static long ToLong(this string text) => long.Parse(text);
        public static long[] ToLongArray(this string text) => text.Split(' ').Select(txt => txt.ToLong()).ToArray();

        public static string ToJoinedString(this string[] texts, string separator = "") =>
            string.Join(separator, texts);

        public static string ToJoinedString(this char[] chars) => string.Join("", chars);
        public static string ToYESNO(this bool b) => b ? "YES" : "NO";
        public static string ToYesNo(this bool b) => b ? "Yes" : "No";
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