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
2 3 1 1
",
            @"
2
")]
        [InlineData(
            @"
10 7 3 4
",
            @"
3570
")]
        [InlineData(
            @"
100000 100000 99999 99999
",
            @"
1
")]
        [InlineData(
            @"
100000 100000 44444 55555
",
            @"
738162020
")]
        public void Test(string inputLines, string expectOutputLines)
        {
            // var reader = new TestInputReader(inputLines);
            // var writer = new TestOutputWriter();
            // new Solver(reader, writer).Solve();
            // Assert.Equal(expectOutputLines, writer.OutputLines);
        }
    }
}