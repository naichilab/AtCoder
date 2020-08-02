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
4 3
1 2 1 3
1 3
2 4
3 3
",
            @"
2
3
1
")]
        [InlineData(
            @"
10 10
2 5 6 5 2 1 7 9 7 2
5 5
2 4
6 7
2 2
7 8
7 9
1 8
6 9
8 10
6 8
",
            @"
1
2
2
1
2
2
6
3
3
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