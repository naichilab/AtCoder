using System.Collections.Generic;
using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData(
            @"
3
",
            @"
6
")]
        [InlineData(
            @"
10
",
            @"
3628800
")]
        [InlineData(
            @"
100000
",
            @"
457992974
")]
        public void Test(string inputLines, string expectOutputLines)
        {
            var reader = new TestInputReader(inputLines);
            var writer = new TestOutputWriter();
            new Solver(reader, writer).Solve();
            Assert.Equal(expectOutputLines, writer.OutputLines);
        }
    }
}