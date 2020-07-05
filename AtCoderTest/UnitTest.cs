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
2 3 2
..#
###
",
            @"
5
")]
        [InlineData(
            @"
2 3 4
..#
###
",
            @"
1
")]
        [InlineData(
            @"
2 2 3
##
##
",
            @"
0
")]
        [InlineData(
            @"
6 6 8
..##..
.#..#.
#....#
######
#....#
#....#
",
            @"
208
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