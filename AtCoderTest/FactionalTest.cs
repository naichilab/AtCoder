using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class FactionalTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 1 * 2)]
        [InlineData(3, 1 * 2 * 3)]
        [InlineData(4, 1 * 2 * 3 * 4)]
        [InlineData(5, 1 * 2 * 3 * 4 * 5)]
        [InlineData(6, 1 * 2 * 3 * 4 * 5 * 6)]
        [InlineData(7, 1 * 2 * 3 * 4 * 5 * 6 * 7)]
        [InlineData(8, 1 * 2 * 3 * 4 * 5 * 6 * 7 * 8)]
        [InlineData(9, 1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9)]
        public void Test(long n, long expected)
        {
            Assert.Equal(expected, Util.Factional(n));
        }
    }
}