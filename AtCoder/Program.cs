﻿using System;
using System.Collections.Generic;
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
            var X = numbers[0];
            var Y = numbers[1];

            var prise = 0;
            if (X == 3)
            {
                prise += 100000;
            }
            else if (X == 2)
            {
                prise += 200000;
            }
            else if (X == 1)
            {
                prise += 300000;
            }

            if (Y == 3)
            {
                prise += 100000;
            }
            else if (Y == 2)
            {
                prise += 200000;
            }
            else if (Y == 1)
            {
                prise += 300000;
            }

            if (X == 1 && Y == 1)
            {
                prise += 400000;
            }


            _outputWriter.WriteLine(prise.ToString());
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