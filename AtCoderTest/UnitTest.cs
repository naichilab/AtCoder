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
2
3 2
7 5
",
            @"
3
")]
        [InlineData(
            @"
3
1 5 3
10 7 3
",
            @"
0
")]
        [InlineData(
            @"
3
3 2 5
6 9 8
",
            @"
2
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