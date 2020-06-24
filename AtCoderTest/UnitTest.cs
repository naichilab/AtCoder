using System.Collections.Generic;
using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData(
            new[] {"10 7 100"},
            new[] {"9"})]
        [InlineData(
            new[] {"2 1 100000000000"},
            new[] {"1000000000"})]
        [InlineData(
            new[] {"1000000000 1000000000 100"},
            new[] {"0"})]
        [InlineData(
            new[] {"1234 56789 314159265"},
            new[] {"254309"})]
        public void Test(string[] inputs, string[] expectOutputs)
        {
            var reader = new TestInputReader(inputs);
            var writer = new TestOutputWriter();
            new Solver(reader, writer).Solve();
            Assert.Equal(expectOutputs, writer.Outputs);
        }
    }
}