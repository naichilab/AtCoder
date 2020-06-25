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
240
600
1800
3600
4800
7200
10000
0
",
            @"
10000
")]
        [InlineData(
            @"
10400
10300
10100
9800
9500
8500
7000
5000
",
            @"
10400
")]
        [InlineData(
            @"
0
0
0
0
0
0
0
0
",
            @"
0
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