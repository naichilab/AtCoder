using System.Collections.Generic;
using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData(new string[] {"5 3", "50 100 80 120 80"}, new string[] {"210"})]
        [InlineData(new string[] {"1 1", "1000"}, new string[] {"1000"})]
        public void Test(string[] inputs, string[] expectOutputs)
        {
            var reader = new TestInputReader(inputs);
            var writer = new TestOutputWriter();
            new Solver(reader, writer).Solve();
            Assert.Equal(expectOutputs, writer.Outputs);
        }
    }

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

        public string Read()
        {
            return _lines.Dequeue();
        }
    }

    internal class TestOutputWriter : IOutputWriter
    {
        public List<string> Outputs { get; set; } = new List<string>();

        public void Write(string output)
        {
            Outputs.Add(output);
        }
    }
}