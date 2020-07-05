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
6
AC
TLE
AC
AC
WA
TLE
",
            @"
AC x 3
WA x 1
TLE x 2
RE x 0
")]
        [InlineData(
            @"
10
AC
AC
AC
AC
AC
AC
AC
AC
AC
AC
",
            @"
AC x 10
WA x 0
TLE x 0
RE x 0
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