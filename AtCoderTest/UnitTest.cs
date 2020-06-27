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
cupofcoffee
cupofhottea
",
            @"
4
")]
        [InlineData(
            @"
abcde
bcdea
",
            @"
5
")]
        [InlineData(
            @"
apple
apple
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