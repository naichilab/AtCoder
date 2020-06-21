using System.Collections.Generic;
using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData(new string[] {"2"}, new string[] {"b"})]
        [InlineData(new string[] {"27"}, new string[] {"aa"})]
        [InlineData(new string[] {"123456789"}, new string[] {"jjddja"})]
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