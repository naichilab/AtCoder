using System;

interface IInputReader
{
    string Read();
}

class ConsoleInputReader : IInputReader
{
    public string Read() => Console.ReadLine();
}

class Program
{
    static void Main(string[] args)
    {
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