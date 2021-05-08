using System.Collections.Generic;
using System.Linq;
using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData(
            @"
6
123 223 123 523 200 2000
",
            @"
4
")]
        [InlineData(
            @"
5
1 2 3 4 5
",
            @"
0
")]
        [InlineData(
            @"
8
199 100 200 400 300 500 600 200
",
            @"
9
")]    
        [InlineData(
            @"
2
1000000000 0
",
            @"
1
")]
        public void Test(string inputLines, string expectOutputLines)
        {
            var reader = new TestInputReader(inputLines);
            var writer = new TestOutputWriter();
            new Solver(reader, writer).Solve();
            Assert.Equal(expectOutputLines, writer.OutputLines);
        }

        [Fact]
        public void TestStringToString2()
        {
            Assert.Equal(Combination.nCk(1, 2), 0);
            Assert.Equal(Combination.nCk(3, 2), 3);
            Assert.Equal(Combination.nCk(4, 2), 6);
        }
    }
}