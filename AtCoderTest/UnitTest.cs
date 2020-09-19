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
5
1 2
6 6
4 4
3 3
3 2
",
            @"
Yes
")]
        [InlineData(
            @"
5
1 1
2 2
3 4
5 5
6 6
",
            @"
No
")]
        [InlineData(
            @"
6
1 1
2 2
3 3
4 4
5 5
6 6
",
            @"
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