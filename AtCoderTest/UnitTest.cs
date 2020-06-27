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
3
1
2
",
            @"
2
")]
        [InlineData(
            @"
4
3
4
1
2
",
            @"
-1
")]
        [InlineData(
            @"
5
3
3
4
2
4
",
            @"
3
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