using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class ModCombinationTest
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(3, 2, 3)]
        [InlineData(5, 2, 10)]
        [InlineData(5, 2, 10)]
        [InlineData(13, 3, 286)]
        public void TestCombination1(long m, long n, long expected)
        {
            Assert.Equal(expected, Util.ModCombination(m, n));
        }
    }
}