using System.Collections.Generic;
using AtCoder;

namespace AtCoderTest
{
    internal class TestOutputWriter : IOutputWriter
    {
        public List<string> Outputs { get; set; } = new List<string>();

        public void WriteLine(string output)
        {
            Outputs.Add(output);
        }
    }
}