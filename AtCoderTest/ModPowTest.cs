using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class ModPowTest
    {
        [Theory]
        [InlineData(3, 45, 1000000007, 644897553)]
        [InlineData(2, 100000, 1000000007, 607723520)]
        public void 累乗(long a, long n, long mod, long expected)
        {
            Assert.Equal(expected, Util.ModPow(a, n, mod));
        }
    }
}