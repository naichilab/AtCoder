using System.Collections.Generic;
using System.IO;
using AtCoder;

namespace AtCoderTest
{
    internal class TestInputReader : IInputReader
    {
        private readonly Queue<string> _lines = new Queue<string>();

        public TestInputReader(string lines)
        {
            using (var sr = new StringReader(lines))
            {
                while (sr.Peek() > -1)
                {
                    //一行読み込んで表示する
                    var line = sr.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        _lines.Enqueue(line);
                    }
                }
            }
        }

        public string ReadLine()
        {
            return _lines.Dequeue();
        }
    }
}