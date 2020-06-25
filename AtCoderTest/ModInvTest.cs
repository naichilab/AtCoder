using AtCoder;
using Xunit;

namespace AtCoderTest
{
    public class ModInvTest
    {
        [Theory]
        [InlineData(1, 13, 1)]
        [InlineData(2, 13, 7)]
        [InlineData(3, 13, 9)]
        [InlineData(4, 13, 10)]
        [InlineData(5, 13, 8)]
        [InlineData(6, 13, 11)]
        [InlineData(7, 13, 2)]
        [InlineData(8, 13, 5)]
        [InlineData(9, 13, 3)]
        [InlineData(10, 13, 4)]
        [InlineData(11, 13, 6)]
        [InlineData(12, 13, 12)]
        public void Test逆元(long a, long mod, long inv)
        {
            Assert.Equal(inv, Util.ModInv(a, mod));
        }
    }
}