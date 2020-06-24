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
1 2 3
",
            @"
YES
")]
        [InlineData(
            @"
5
1 2 3 4 5
",
            @"
NO
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