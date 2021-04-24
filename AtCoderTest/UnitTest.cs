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
3 8 7 1
",
            @"
Left
")]
        [InlineData(
            @"
3 4 5 2
",
            @"
Balanced
")]
        [InlineData(
            @"
1 7 6 4
",
            @"
Right
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