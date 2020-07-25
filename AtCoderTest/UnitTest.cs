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
5 3
96 98 95 100 20
",
            @"
Yes
No
")]
        [InlineData(
            @"
3 2
1001 869120 1001
",
            @"
No
")]
        [InlineData(
            @"
15 7
3 1 4 1 5 9 2 6 5 3 5 8 9 7 9
",
            @"
Yes
Yes
No
Yes
Yes
No
Yes
Yes
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