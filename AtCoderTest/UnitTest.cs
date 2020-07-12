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
5 7 5
",
            @"
7
")]
        [InlineData(
            @"
1 1 7
",
            @"
7
")]
        [InlineData(
            @"
-100 100 100
",
            @"
-100
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