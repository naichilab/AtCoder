using System.Collections.Generic;
using AtCoder;

namespace AtCoderTest
{
    internal class TestInputReader : IInputReader
    {
        private readonly Queue<string> _lines = new Queue<string>();

        public TestInputReader(params string[] lines)
        {
            foreach (var line in lines)
            {
                _lines.Enqueue(line);
            }
        }

        public string ReadLine()
        {
            return _lines.Dequeue();
        }
    }
}