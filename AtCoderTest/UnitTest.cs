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
4 5
0 5
-2 4
3 4
4 -4
",
            @"
3
")]
        [InlineData(
            @"
12 3
1 1
1 1
1 1
1 1
1 2
1 3
2 1
2 2
2 3
3 1
3 2
3 3
",
            @"
7
")]
        [InlineData(
            @"
20 100000
14309 -32939
-56855 100340
151364 25430
103789 -113141
147404 -136977
-37006 -30929
188810 -49557
13419 70401
-88280 165170
-196399 137941
-176527 -61904
46659 115261
-153551 114185
98784 -6820
94111 -86268
-30401 61477
-55056 7872
5901 -163796
138819 -185986
-69848 -96669
",
            @"
6
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