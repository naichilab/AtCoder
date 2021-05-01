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
1 10 10
3 5
",
            @"
2.857142857142857
")]
        [InlineData(
            @"
1 10 10
3 2
",
            @"
0.0
")]
        [InlineData(
            @"
5 896 483
228 59
529 310
339 60
78 266
659 391
",
            @"
245.3080684596577
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